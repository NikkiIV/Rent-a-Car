using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACar.Data.Models;

namespace RentACar.Data
{
    public class RentACarDbContext : IdentityDbContext
    {
        public DbSet<Car> Cars { get; init; }

        public RentACarDbContext(
            DbContextOptions<RentACarDbContext> options)
            : base(options)
        {
        }
    }
}