using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    public class CarStatus
    {
        public int Id { get; init; }

        [Required]
        public string Experience { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
