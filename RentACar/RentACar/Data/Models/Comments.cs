using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    public class Comments
    {

        public int Id { get; init; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
