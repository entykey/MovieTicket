namespace EntityFrameworkWebAPI.Models.Domains
{
    using System.Text.Json.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;

    public class FoodDrink
    {
        [Key]
        public string FoodDrinkId { get; set; }
        public string Name { get; set; }
        public string? ImagePath { get; set; }  // store images in project's directory/uploaded
        public decimal Price { get; set; }
        // Other properties related to food and drinks

        [JsonIgnore]
        public IList<OrderedItem> OrderedItems { get; set; }
    }
}