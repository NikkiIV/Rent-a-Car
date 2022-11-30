using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RentACar.Data.Models
{
    public class History
    {
        [Key]
        [StringLength(64)]
        public int Id { get; set; }

        [Required]
        public DateTime? OrderDate { get; set; }

        ////----USER
        [Required]
        [ForeignKey(nameof(User))]
        public string UserId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

    }
}
