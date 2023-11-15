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
        private Dictionary<string, List<string>> bookedSeatsByMovie = new Dictionary<string, List<string>>();

        public ucBooking()
        {
            InitializeComponent();
            InitializeSeatButtons();
            LoadMovies();
            InitializeComboBox();
            //lblControlName.Text += DateTime.Now.ToString();
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
                    seatButton.MouseDown += SeatButton_MouseDown;

                    tableLayoutPanel1.Controls.Add(seatButton, col, row);
                    seatButtons[row, col] = seatButton;
                }
            }
        }

        // fake data for Movie dbset
        private void LoadMovies()
        {
            // For demonstration purposes, we create two sample movies.
            movies.Add("Movie1", new Movie("Movie 1", Rows, Columns));
            movies.Add("Movie2", new Movie("Movie 2", Rows, Columns));

            // Initialize booked seats dictionary for each movie
            foreach (var movie in movies.Keys)
            {
                bookedSeatsByMovie[movie] = new List<string>();
            }
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
                string selectedMovieKey = cmbMovies.SelectedItem.ToString();

                if (selectedSeats.Count > 0)
                {
                    // Mark selected seats as booked for the selected movie
                    foreach (Seat seat in selectedSeats)
                    {
                        seat.ToggleBookingStatus();
                        UpdateSeatButtonAppearance(seatButtons[seat.Row, seat.Column], seat);

                        string seatId = $"{(char)('A' + seat.Column)}-{seat.Row + 1}";
                        if (!bookedSeatsByMovie[selectedMovieKey].Contains(seatId))
                        {
                            bookedSeatsByMovie[selectedMovieKey].Add(seatId);
                        }
                    }

                    // Clear the selected seats
                    selectedSeats.Clear();

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

            if (bookedSeatsByMovie.ContainsKey(selectedMovieKey))
            {
                // Display the booked seats for the selected movie
                lblBookedSeats.Text = $"Booked Seats (ghế): {string.Join(", ", bookedSeatsByMovie[selectedMovieKey])}";

                // Update the seat buttons based on the booked seats for the selected movie
                foreach (Button seatButton in tableLayoutPanel1.Controls)
                {
                    Seat seat = (Seat)seatButton.Tag;
                    bool isBooked = bookedSeatsByMovie[selectedMovieKey].Contains($"{(char)('A' + seat.Column)}-{seat.Row + 1}");
                    seat.IsBooked = isBooked;
                    UpdateSeatButtonAppearance(seatButton, seat);
                }
            }
            else
            {
                lblBookedSeats.Text = "Booked Seats (ghế): N/A";
            }
        }

        private void cmbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Update the booked seats display when the selected movie changes
            UpdateBookedSeats();

            // Clear the selected seats and reset the total price when switching between movies
            selectedSeats.Clear();
            UpdateTotalPrice();
        }
    }
}
