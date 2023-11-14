namespace MovieTicket
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Windows.Forms;


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

        private const int Rows = 10;
        private const int Columns = 12;
        private const decimal SeatPrice = 45000.0m;

        private Button[,] seatButtons = new Button[Rows, Columns];
        private List<Seat> selectedSeats = new List<Seat>();
        private decimal totalPrice = 0.0m;

        // For demonstration purposes, we use a Dictionary to store movie information and booked seats.
        private Dictionary<string, Movie> movies = new Dictionary<string, Movie>();

        public ucBooking()
        {
            InitializeComponent();
            InitializeSeatButtons();
            LoadMovies();
            InitializeComboBox();
            //AddHeaders();
        }

        private void ucBooking_Load(object sender, EventArgs e)
        {
        }

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
                        Text = $"{(char)('A' + col)}-{row + 1}",
                        Width = 40,
                        Height = 40,
                        Tag = new Seat(row, col),
                        BackColor = System.Drawing.Color.White
                    };

                    seatButton.Click += SeatButton_Click;

                    tableLayoutPanel1.Controls.Add(seatButton, col, row);
                    seatButtons[row, col] = seatButton;
                }
            }
        }

        //private void AddHeaders()
        //{
        //    for (int col = 0; col < Columns; col++)
        //    {
        //        char columnHeader = (char)('A' + col);
        //        Label columnLabel = new Label
        //        {
        //            Text = columnHeader.ToString(),
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            Dock = DockStyle.Fill
        //        };
        //        tableLayoutPanel1.Controls.Add(columnLabel, col, Rows);
        //    }

        //    for (int row = 0; row < Rows; row++)
        //    {
        //        Label rowLabel = new Label
        //        {
        //            Text = (row + 1).ToString(),
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            Dock = DockStyle.Fill
        //        };
        //        tableLayoutPanel1.Controls.Add(rowLabel, Columns, row);
        //    }
        //}

        private void LoadMovies()
        {
            // For demonstration purposes, we create two sample movies.
            movies.Add("Movie1", new Movie("Movie 1", Rows, Columns));
            movies.Add("Movie2", new Movie("Movie 2", Rows, Columns));
        }

        private void InitializeComboBox()
        {
            // Populate the combo box with movie titles
            cmbMovies.Items.AddRange(movies.Keys.ToArray());
            cmbMovies.SelectedIndex = 0; // Select the first movie by default
            UpdateBookedSeats();
        }

        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button seatButton = (Button)sender;
            Seat seat = (Seat)seatButton.Tag;

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

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            try
            {
                if (!movies.ContainsKey("Movie1"))
                {
                    // Create the movie entry if it doesn't exist
                    movies["Movie1"] = new Movie("MovieTitle", Rows, Columns);
                }

                if (selectedSeats.Count > 0)
                {
                    // Mark selected seats as booked
                    foreach (Seat seat in selectedSeats)
                    {
                        seat.ToggleBookingStatus();
                        UpdateSeatButtonAppearance(seatButtons[seat.Row, seat.Column], seat);

                        // Update the movie's booked seats
                        movies["Movie1"].BookedSeats.Add($"{(char)('A' + seat.Column)}-{seat.Row + 1}");
                    }

                    // Clear the selected seats
                    selectedSeats.Clear();

                    // Reset total price
                    UpdateTotalPrice();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
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

            if (movies.ContainsKey(selectedMovieKey))
            {
                // Display the booked seats for the selected movie
                lblBookedSeats.Text = $"Booked Seats: {string.Join(", ", movies[selectedMovieKey].BookedSeats)}";

                // Update the seat buttons based on the booked seats
                foreach (Button seatButton in tableLayoutPanel1.Controls)
                {
                    Seat seat = (Seat)seatButton.Tag;
                    bool isBooked = movies[selectedMovieKey].BookedSeats.Contains($"{(char)('A' + seat.Column)}-{seat.Row + 1}");
                    seat.IsBooked = isBooked;
                    UpdateSeatButtonAppearance(seatButton, seat);
                }
            }
            else
            {
                lblBookedSeats.Text = "Booked Seats: N/A";
            }
        }


        private void cmbMovies_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Update the booked seats display when the selected movie changes
            UpdateBookedSeats();

            // Clear the selected seats and reset the total price when switching between movies
            selectedSeats.Clear();
            UpdateTotalPrice();
        }


        
    }
}
