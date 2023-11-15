namespace MovieTicket.Models
{
    using System;
    using System.Collections.Generic;

    public class Movie
    {
        public string MovieId { get; set; } = Guid.NewGuid().ToString();
        public string Title { get; }
        public int Rows { get; }
        public int Columns { get; }
        public List<string> BookedSeats { get; } = new List<string>();

        public Movie(string title, int rows, int columns)
        {
            Title = title;
            Rows = rows;
            Columns = columns;
        }
    }
}
