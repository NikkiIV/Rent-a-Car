using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    using static DataConstants;

    public class Dealer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(DealerNameMaxLength)]
        public string Name { get; set; }

        [Required]
        [MaxLength(DealerPhoneMaxLength)]
        public string PhoneNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        public IEnumerable<Car> Cars { get; set; } = new List<Car>();
    }
}
