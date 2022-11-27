using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    public class Sales
    {        
        public int Id { get; set; }

        public DateTime? OrderDate { get; set; }

        [Required]
        public string UserId { get; set; }

        public decimal Price { get; set; }

    }
}
