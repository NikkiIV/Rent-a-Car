using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    public class Maintenance
    {
        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Experience { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
