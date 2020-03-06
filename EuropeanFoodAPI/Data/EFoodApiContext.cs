using EuropeanFoodAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace EuropeanFoodAPI.Data
{
    public class EFoodApiContext : DbContext
    {
        public EFoodApiContext(DbContextOptions<EFoodApiContext> options)
            : base(options)
        {
        }

        public DbSet<Food> EuropeanFood { get; set; }
    }
}
