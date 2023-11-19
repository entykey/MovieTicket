namespace EntityFrameworkWebAPI.Models.Domains
{
    using MovieTicket.EFModels;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class Booking
    {
        [Key]
        public string BookingId { get; set; } = Guid.NewGuid().ToString();
        public string ShowId { get; set; }
        public string SeatNumber { get; set; }  // example: A1, F2
        public bool? IsBooked { get; set; }
        public DateTime BookingDate { get; set; } = DateTime.Now;

        // Navigation property
        //public virtual Show? Show { get; set; }
    }
}