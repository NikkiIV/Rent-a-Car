using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        public string FullName { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required]
        public string Comment { get; set; }
    }
}
