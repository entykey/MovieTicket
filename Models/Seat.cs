namespace MovieTicket.Models
{
    using System;


    public class Seat
    {
        public int Row { get; }
        public int Column { get; }
        public bool IsBooked { get; set; }

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
