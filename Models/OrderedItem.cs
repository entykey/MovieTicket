namespace EntityFrameworkWebAPI.Models.Domains
{
    using MovieTicket.EFModels;
    using System.ComponentModel.DataAnnotations;


    public class OrderedItem
    {
        //[Key]
        //public string OrderedItemId { get; set; } = Guid.NewGuid().ToString();
        public string BookingId { get; set; }
        public Booking? Booking { get; set; }
        public string FoodDrinkId { get; set; }
        public FoodDrink? FoodDrink { get; set; }
        public int? Quantity { get; set; } = 1;

    }
}