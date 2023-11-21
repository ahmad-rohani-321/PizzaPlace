using System.ComponentModel.DataAnnotations;

namespace PizzaPlace.Shared
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide a name")]
        public string Name { get; set; } = default!;
        [Required(ErrorMessage = "Please provide street name with house number")]
        public string Street { get; set; } = default!;
        [Required(ErrorMessage = "Please provide a city name")]
        public string City { get; set; } = default!;
    }
}
