using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace RentACar.Data.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
