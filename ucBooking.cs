
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
        private  decimal SeatPrice = 45000.0m;

        private Button[,] seatButtons = new Button[Rows, Columns];
        private List<Seat> selectedSeats = new List<Seat>();
        private decimal totalPrice = 0.0m;


        private Dictionary<string, string> movieData = new Dictionary<string, string>();
        private Dictionary<string, string> showData = new Dictionary<string, string>();


        public ucBooking()
        {
            InitializeComponent();
            InitializeSeatButtons();
            LoadMovies();
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
            var result = from m in dbContext.Movies
                         select new { m.Title, m.MovieId };

            foreach (var item in result)
            {
                movieData[item.Title] = item.MovieId;
                cmbMovies.Items.Add(item.Title);
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
            lblTotalPrice.Text = $"Total Price: {totalPrice:C}";
        }

        public async Task AddBooking(Seat seat, String movieId)
        {
            string seatId = seat.ToString();
            String showId = showData[GetHash(cbShow.SelectedItem.ToString(), movieId)];

            dbContext.Bookings.Add(new Bookings()
            {
                BookingId = Guid.NewGuid().ToString(),
                ShowId = showId,
                SeatNumber = seatId,
                IsBooked = true,
                BookingDate = DateTime.Now

            });

            await Task.FromResult(dbContext.SaveChanges());
        }

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedMovieKey = cmbMovies.SelectedItem.ToString();
                string movieId = movieData[selectedMovieKey];

                if (selectedSeats.Count > 0)
                {
                    // Mark selected seats as booked for the selected movie
                    foreach (Seat seat in selectedSeats)
                    {
                        seat.ToggleBookingStatus();
                        UpdateSeatButtonAppearance(seatButtons[seat.Row, seat.Column], seat);

                        AddBooking(seat, movieId);
                    }

                    // Clear the selected seats
                    //////// mới xóa
                    //selectedSeats.Clear();

                    // Reset total price
                    UpdateTotalPrice();

                    // Update the combo box to reflect the changes
                    UpdateBookedSeats();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            string movieId = movieData[selectedMovieKey];


            String showId = showData[GetHash(cbShow.SelectedItem.ToString(), movieId)];


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

            //if (lblBookedSeats.Text.EndsWith(", "))
            //{
            //    lblBookedSeats.Text = lblBookedSeats.Text.Substring(0, lblBookedSeats.Text.Length - ", ".Length);
            //    lblBookedSeats.Text = lblBookedSeats.Text + " ";
            //}



            selectedSeats.Clear();
        }

        private void cbShow_SelectedIndexChanged(object sender, EventArgs e)
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



            string selectedMovieKey = cmbMovies.SelectedItem.ToString();
            string movieId = movieData[selectedMovieKey];

            //// --- HERE -> get Booking and change the Seats
            String showId = showData[GetHash(cbShow.SelectedItem.ToString(), movieId)];


            var querySeats = from b in dbContext.Bookings
                             where b.ShowId == showId
                             select b.SeatNumber;

            List<string> seats = querySeats.ToList();

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

            if(price != null)
            {
                SeatPrice = decimal.Parse(price);
            }


            var query = from s in dbContext.Shows
                        where s.MovieId == movieId
                        select new { s.StartTime, s.ShowId };



            foreach (var item in query)
            {
                cbShow.Items.Add(item.StartTime.Value.ToString("MM/dd/yy HH:mm tt"));

                String tmp = GetHash(item.StartTime.Value.ToString("MM/dd/yy HH:mm tt"), movieId);

                showData[tmp] = item.ShowId;
            }
            cbShow.SelectedIndex = 0;
            cbShow_SelectedIndexChanged(sender, e);


            // Update the booked seats display when the selected movie changes
            UpdateBookedSeats();

            // Clear the selected seats and reset the total price when switching between movies
            UpdateTotalPrice();
        }

        // helper method
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

        private void ucBooking_Load(object sender, EventArgs e)
        {
        }


    }
}

