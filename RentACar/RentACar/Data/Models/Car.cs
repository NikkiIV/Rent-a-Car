using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    using static DataConstants;

    public class Car
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(CarBrandMaxLenght)]
        public string Brand { get; set; }

        [Required]
        [MaxLength(CarModelMaxLenght)]
        public string Model { get; set; }

        [Required]
        [MaxLength(CarDescriptionMaxLenght)]
        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        public int Year { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; init; }
    }
}
