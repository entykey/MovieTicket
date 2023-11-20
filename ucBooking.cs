
namespace MovieTicket
{
    using Models;
    using MovieTicket.EFModels;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows.Forms;
    using System.Security.Cryptography;
    using System.Text;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;
    using Button = System.Windows.Forms.Button;
    using static System.Net.Mime.MediaTypeNames;
    using System.Reflection;
    using System.Drawing;
    using Image = System.Drawing.Image;



    public partial class ucBooking : UserControl
    {
        private static ucBooking _instance;

        public static ucBooking Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new ucBooking();
                return _instance;
            }
        }

        #region EntityFramework entity
        CRVCinemaEntities dbContext = new CRVCinemaEntities();
        #endregion

        private const int Rows = 10;
        private const int Columns = 12;
        private decimal SeatPrice = 45000.0m;

        private Button[,] seatButtons = new Button[Rows, Columns];
        private List<Seat> selectedSeats = new List<Seat>();
        private decimal totalPrice = 0.0m;


        private Dictionary<string, string> movieData = new Dictionary<string, string>();
        private Dictionary<string, string> showData = new Dictionary<string, string>();
        private Dictionary<string, string> foodData = new Dictionary<string, string>();


        public ucBooking()
        {
            InitializeComponent();
            InitializeSeatButtons();
            LoadMovies();
            LoadFoods();
            InitializeComboBox();
        }



        // Check ở đây -----
        private void InitializeSeatButtons()
        {
            tableLayoutPanel1.RowCount = Rows;
            tableLayoutPanel1.ColumnCount = Columns;

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Columns; col++)
                {
                    Button seatButton = new Button
                    {
                        Text = $"{(char)('A' + row)}-{col + 1}",
                        Width = 40,
                        Height = 40,
                        Tag = new Seat(row, col),
                        BackColor = System.Drawing.Color.White
                    };

                    seatButton.Click += SeatButton_Click;
                    seatButton.MouseDown += SeatButton_MouseDown;

                    tableLayoutPanel1.Controls.Add(seatButton, col, row);
                    seatButtons[row, col] = seatButton;
                }
            }
        }

        // fake data for Movie dbset
        private void LoadMovies()
        {
            cmbMovies.Items.Clear();
            movieData.Clear();

            var result = from m in dbContext.Movies
                         select new { m.Title, m.MovieId };

            foreach (var item in result)
            {
                movieData[item.Title] = item.MovieId;
                cmbMovies.Items.Add(item.Title);
            }
        }

        private void LoadFoods()
        {
            cbFood.Items.Clear();
            foodData.Clear();

            var query = from d in dbContext.FoodDrinks
                        select new { d.FoodDrinkId, d.Name, d.Price };

            foreach (var item in query)
            {
                foodData[item.Name + " - " + item.Price] = item.FoodDrinkId;
                cbFood.Items.Add(item.Name + " - " + item.Price);
            }
        }

        private void InitializeComboBox()
        {
            cmbMovies.SelectedIndex = 0; // Select the first movie by default

            string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            string movieId = movieData[selectedMovieKey];

            // set giá
            var price = dbContext.Movies
            .Where(m => m.MovieId == movieId)
            .Select(m => m.SeatPrice)
            .FirstOrDefault()
            .ToString();

            if (price != null)
            {
                SeatPrice = decimal.Parse(price);
            }

            UpdateBookedSeats();
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            if (cbShow.Text == "")
            {
                MessageBox.Show("Cần suất chiếu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Button seatButton = (Button)sender;
            Seat seat = (Seat)seatButton.Tag;

            if (seatButton.BackColor == System.Drawing.Color.Gray) return;

            ToggleSeatSelection(seatButton, seat);
        }

        private void SeatButton_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // Right-click to un-select the seat
                Button seatButton = (Button)sender;
                Seat seat = (Seat)seatButton.Tag;

                if (selectedSeats.Contains(seat))
                {
                    selectedSeats.Remove(seat);
                    seatButton.BackColor = seat.IsBooked ? System.Drawing.Color.Gray : System.Drawing.Color.White;
                }
            }
        }

        private void ToggleSeatSelection(Button seatButton, Seat seat)
        {
            if (selectedSeats.Contains(seat))
            {
                // Seat is already selected, un-select it
                selectedSeats.Remove(seat);
                seatButton.BackColor = seat.IsBooked ? System.Drawing.Color.Gray : System.Drawing.Color.White;
            }
            else
            {
                // Select the seat
                selectedSeats.Add(seat);
                seatButton.BackColor = System.Drawing.Color.Yellow;
            }

            UpdateTotalPrice();
        }

        private void UpdateTotalPrice()
        {
            totalPrice = selectedSeats.Count * SeatPrice;

            foreach (var item in cbOrdered.Items)
            {
                string itemText = item.ToString();
                string[] parts = itemText.Split('-');

                int index = itemText.LastIndexOf("x");

                int count = int.Parse(itemText.Substring(index + 1));


                // Cộng thêm tiền * số lượng
                totalPrice += decimal.Parse(parts[1].Trim()) * count;


            }

            lblTotalPrice.Text = $"Total Price: {totalPrice:C}";
        }

        public async Task AddBooking(string seatList, String movieId, string bookingId, string showId)
        {
            dbContext.Bookings.Add(new Bookings()
            {
                BookingId = bookingId,
                ShowId = showId,
                SeatNumber = seatList,
                IsBooked = true,
                BookingDate = DateTime.Now

            });
            await Task.FromResult(dbContext.SaveChanges());
        }


        public async Task AddFoodDrinks(string seatList, String movieId, string bookingId, string showId)
        {
            try
            {
                foreach (var cbItem in cbOrdered.Items)
                {
                    string item = cbItem.ToString();

                    int index = item.LastIndexOf("x");
                    int quantity = int.Parse(item.Substring(index + 1));

                    var itemSplit = item.Split('-');

                    string foodId = foodData[itemSplit[0].Trim() + " - " + itemSplit[1].Trim()];

                    dbContext.OrderedItems.Add(new OrderedItems()
                    {
                        BookingId = bookingId,
                        FoodDrinkId = foodId,
                        Quantity = quantity
                    });

                }
                await Task.FromResult(dbContext.SaveChanges());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Exception: {ex.Message}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void btnBookNow_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count <= 0)
            {
                MessageBox.Show("Cần chọn ghế", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                string selectedMovieKey = cmbMovies.SelectedItem.ToString();
                string movieId = movieData[selectedMovieKey];
                String showId = showData[GetHash(cbShow.SelectedItem.ToString(), movieId)];


                if (selectedSeats.Count > 0)
                {
                    string seatList = "";
                    // Mark selected seats as booked for the selected movie
                    foreach (Seat seat in selectedSeats)
                    {
                        seat.ToggleBookingStatus();
                        UpdateSeatButtonAppearance(seatButtons[seat.Row, seat.Column], seat);

                        seatList += seat.ToString() + ",";

                    }

                    string bookingId = Guid.NewGuid().ToString();
                    seatList = seatList.Substring(0, seatList.Length - 1);

                    await AddBooking(seatList, movieId, bookingId, showId);
                    await AddFoodDrinks(seatList, movieId, bookingId, showId);

                    // Reset total price
                    UpdateTotalPrice();

                    // Update the combo box to reflect the changes
                    UpdateBookedSeats();



                    // Generate PDF receipt
                    rtxtPreview.Clear();
                    StringBuilder receiptText = new StringBuilder();
                    receiptText.AppendLine("******************************************");
                    receiptText.AppendLine("**                CRV Cinema               **");
                    receiptText.AppendLine("******************************************");
                    receiptText.AppendLine("Ngày in vé: " + DateTime.Now + "\n");
                    receiptText.AppendLine("Số ghế: " + seatList + "\n\n");
                    

                    // Loop through each row in the FoodDrink selected
                    foreach (var cbItem in cbOrdered.Items)
                    {
                        string item = cbItem.ToString();
                        receiptText.AppendLine(item);
                    }

                    receiptText.AppendLine("\nĐịa chỉ: 280 An Dương Vương, Q5, HCM");
                    receiptText.AppendLine("Note: Quý khách vui lòng đến trước giờ chiếu khoảng 15 phút để ổn định chỗ ngồi!");

                    // Set the generated text to the RichTextBox
                    rtxtPreview.Text = receiptText.ToString();


                    // Xem có cần có food ordered không? => clear
                    cbOrdered.Items.Clear();
                }

                // FoodDrinks

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            //string movieId = movieData[selectedMovieKey];

            cbOrdered.Items.Clear();


            //if (cbShow.SelectedItem != null)
            //{
            //    String showId = showData[GetHash(cbShow.SelectedItem.ToString(), movieId)];
            //}



            // Clear the selected seats without marking them as booked
            foreach (Seat seat in selectedSeats)
            {
                Button seatButton = seatButtons[seat.Row, seat.Column];
                seatButton.BackColor = seat.IsBooked ? System.Drawing.Color.Gray : System.Drawing.Color.White;
            }

            // Clear the selected seats
            selectedSeats.Clear();

            // Reset total price
            UpdateTotalPrice();
        }

        private void UpdateSeatButtonAppearance(Button seatButton, Seat seat)
        {
            seatButton.BackColor = seat.IsBooked ? System.Drawing.Color.Gray : System.Drawing.Color.White;
        }

        private void UpdateBookedSeats()
        {
            string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            string movieId = movieData[selectedMovieKey];

            selectedSeats.Sort();
            foreach (Seat seat in selectedSeats)
            {

                foreach (Button seatButton in tableLayoutPanel1.Controls)
                {
                    Seat seatReturned = (Seat)seatButton.Tag;

                    if (seat.Row == seatReturned.Row && seat.Column == seatReturned.Column)
                    {
                        seatReturned.IsBooked = true;
                        UpdateSeatButtonAppearance(seatButton, seatReturned);

                        lblBookedSeats.Text = lblBookedSeats.Text + ", " + seat.ToString();

                    }
                }
            }

            selectedSeats.Clear();
        }

        private void cbShow_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset
            lblBookedSeats.Text = "Booked seats (ghế): ";
            lblTotalPrice.Text = $"Total Price: $0.00";

            foreach (Button seatButton in tableLayoutPanel1.Controls)
            {
                seatButton.BackColor = System.Drawing.Color.White;

                // Lấy Seat từ Tag của Button
                Seat seat = (Seat)seatButton.Tag;

                // Reset trạng thái đặt chỗ
                seat.IsBooked = false;
            }



            string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            string movieId = movieData[selectedMovieKey];

            //// --- HERE -> get Booking and change the Seats
            String showId = showData[GetHash(cbShow.SelectedItem.ToString(), movieId)];


            var querySeats = from b in dbContext.Bookings
                             where b.ShowId == showId
                             select b.SeatNumber;

            List<string> seats = new List<string>();
            // querySeats.ToList();
            foreach (var item in querySeats.ToList())
            {
                var split = item.Split(',');
                foreach (var seat in split)
                {
                    seats.Add(seat);
                }
            }


            selectedSeats.Clear();

            for (var i = 0; i < seats.Count; i++)
            {
                string seatCode = seats[i];

                char rowChar = seatCode[0]; // Lấy ký tự đầu tiên

                int column = int.Parse(seatCode.Substring(2)) - 1; // Chuyển đổi phần số, giả sử số đó có thể có nhiều hơn một chữ số
                int row = rowChar - 'A'; // Chuyển đổi ký tự thành số (ví dụ: 'A' -> 0, 'B' -> 1, ...)

                Seat seat = new Seat(row, column);
                selectedSeats.Add(seat);
            }
            UpdateBookedSeats();
            //Text = $"{(char)('A' + row)}-{col + 1}";
            //seatButtons[row, col] = seatButton;
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset
            lblBookedSeats.Text = "Booked seats (ghế): ";
            lblTotalPrice.Text = $"Total Price: ";

            foreach (Button seatButton in tableLayoutPanel1.Controls)
            {
                seatButton.BackColor = System.Drawing.Color.White;

                // Lấy Seat từ Tag của Button
                Seat seat = (Seat)seatButton.Tag;

                // Reset trạng thái đặt chỗ
                seat.IsBooked = false;
            }


            cbShow.Items.Clear();
            selectedSeats.Clear();

            string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            string movieId = movieData[selectedMovieKey];

            // set giá
            var price = dbContext.Movies
            .Where(m => m.MovieId == movieId)
            .Select(m => m.SeatPrice)
            .FirstOrDefault()
            .ToString();

            if (price != null)
            {
                SeatPrice = decimal.Parse(price);
            }


            var query = from s in dbContext.Shows
                        where s.MovieId == movieId
                        select new { s.StartTime, s.ShowId };


            if (query.Any())
            {
                foreach (var item in query)
                {
                    cbShow.Items.Add(item.StartTime.Value.ToString("MM/dd/yy HH:mm tt"));

                    String tmp = GetHash(item.StartTime.Value.ToString("MM/dd/yy HH:mm tt"), movieId);

                    showData[tmp] = item.ShowId;
                }
                cbShow.SelectedIndex = 0;
                cbShow_SelectedIndexChanged(sender, e);
            }



            // Update the booked seats display when the selected movie changes
            UpdateBookedSeats();

            // Clear the selected seats and reset the total price when switching between movies
            UpdateTotalPrice();
        }

        #region helper methods
        private static string GetHash(string firstString, string secondString)
        {
            string combinedString = $"{firstString}{secondString}";

            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(combinedString);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                StringBuilder stringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    stringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return stringBuilder.ToString();
            }
        }

        #endregion

        private void ucBooking_Load(object sender, EventArgs e)
        {
        }


        private void btnFetch_Click(object sender, EventArgs e)
        {
            LoadMovies();
            LoadFoods();
            cbShow.Items.Clear();
            cbOrdered.Items.Clear();

            lblBookedSeats.Text = "Booked seats (ghế): ";
            lblTotalPrice.Text = $"Total Price: $0.00";

            foreach (Button seatButton in tableLayoutPanel1.Controls)
            {
                seatButton.BackColor = System.Drawing.Color.White;

                // Lấy Seat từ Tag của Button
                Seat seat = (Seat)seatButton.Tag;

                // Reset trạng thái đặt chỗ
                seat.IsBooked = false;
            }
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            if (cbFood.Text == "") return;

            String text = cbFood.Text + " - x1";
            int index = text.LastIndexOf("x");
            decimal quantity = 1;

            foreach (string item in cbOrdered.Items)
            {
                var itemSplit = item.Split('-');
                var cbFoodSplit = cbFood.Text.Split('-');

                if (itemSplit[0].Trim() == cbFoodSplit[0].Trim() && itemSplit[1].Trim() == cbFoodSplit[1].Trim())
                {
                    quantity = decimal.Parse(item.Substring(index + 1));

                    cbOrdered.Items.Remove(item);

                    text = cbFood.Text + " - x" + (quantity + 1);
                    cbOrdered.Items.Add(text);

                    UpdateTotalPrice();

                    if (cbOrdered.Items.Count > 0)
                    {
                        cbOrdered.SelectedIndex = 0;
                    }

                    return;
                }

            }

            cbOrdered.Items.Add(text);
            UpdateTotalPrice();

            if (cbOrdered.Items.Count > 0)
            {
                cbOrdered.SelectedIndex = 0;
            }
        }

        private void btnRemoveFood_Click(object sender, EventArgs e)
        {
            if (cbOrdered.SelectedIndex == -1) return;

            string text;
            int index = cbOrdered.Text.LastIndexOf("x");
            var split = cbOrdered.Text.Split('-');

            decimal quantity = decimal.Parse(cbOrdered.Text.Substring(index + 1));
            text = split[0].Trim() + " - " + split[1].Trim() + " - x" + (quantity - 1);

            //cbOrdered.Items.RemoveAt(cbOrdered.SelectedIndex);
            //if(quantity -1 > 0)
            //{
            //    cbOrdered.Items.Add(text);
            //}
            // test

            cbOrdered.Items[cbOrdered.SelectedIndex] = text;
            if (quantity - 1 <= 0)
            {
                cbOrdered.Items.RemoveAt(cbOrdered.SelectedIndex);

                if (cbOrdered.Items.Count > 0)
                {
                    cbOrdered.SelectedIndex = 0;
                }
            }



            UpdateTotalPrice();
        }

        private void btnRemoveFoodAll_Click(object sender, EventArgs e)
        {
            if (cbOrdered.SelectedIndex == -1) return;

            cbOrdered.Items.RemoveAt(cbOrdered.SelectedIndex);
            UpdateTotalPrice();

            if (cbOrdered.Items.Count > 0)
            {
                cbOrdered.SelectedIndex = 0;
            }
        }

        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected item from the ComboBox
            string selectedFoodDrinkName = cbFood.SelectedItem?.ToString().Split('-')[0].Trim();

            // Check if a valid item is selected
            if (!string.IsNullOrEmpty(selectedFoodDrinkName))
            {
                // Find the corresponding FoodDrink in the database
                var selectedFoodDrink = dbContext.FoodDrinks.FirstOrDefault(fd => fd.Name == selectedFoodDrinkName);

                // Check if the FoodDrink is found
                if (selectedFoodDrink != null)
                {
                    // Display the image in the PictureBox
                    try
                    {
                        // Check if the image path is not empty
                        if (!string.IsNullOrEmpty(selectedFoodDrink.ImagePath))
                        {
                            // Load and display the image in the PictureBox
                            pbFoodDrink.Image = Image.FromFile(selectedFoodDrink.ImagePath);
                        }
                        else
                        {
                            // Clear the PictureBox if the image path is empty
                            pbFoodDrink.Image = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region printing

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(rtxtPreview.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            // show the dialog
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        #endregion


    }
}