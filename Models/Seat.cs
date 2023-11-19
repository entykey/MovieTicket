namespace MovieTicket.Models
{
    using System;


    public class Seat : IComparable<Seat>
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

        public override string ToString()
        {
            return $"{(char)('A' + Row)}-{Column + 1}";
        }

        public int CompareTo(Seat other)
        {
            // Sử dụng ToString để so sánh
            return this.ToString().CompareTo(other.ToString());
        }

    }
}
