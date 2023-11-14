namespace MovieTicket
{
    using System;
    using System.Collections.Generic;
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
        private const int Columns = 10;
        private const decimal SeatPrice = 45000.0m;

        private Button[,] seatButtons = new Button[Rows, Columns];
        private List<Seat> selectedSeats = new List<Seat>();
        private decimal totalPrice = 0.0m;

        public ucBooking()
        {
            InitializeComponent();
            InitializeSeatButtons();
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
            // Mark selected seats as booked
            foreach (Seat seat in selectedSeats)
            {
                seat.ToggleBookingStatus();
                UpdateSeatButtonAppearance(seatButtons[seat.Row, seat.Column], seat);
            }

            // Clear the selected seats
            selectedSeats.Clear();

            // Reset total price
            UpdateTotalPrice();
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

        public class Seat
        {
            public int Row { get; }
            public int Column { get; }
            public bool IsBooked { get; private set; }

            public Seat(int row, int column)
            {
                Row = row;
                Column = column;
                IsBooked = false;
            }

            public void ToggleBookingStatus()
            {
                IsBooked = !IsBooked;
            }
        }
    }
}
