using AsianFoodAPI.Models;
using Microsoft.EntityFrameworkCore;
using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace AsianFoodAPI.Data
{
    public class AsianFoodContext : DbContext
    {
        public AsianFoodContext(DbContextOptions<AsianFoodContext> options)
            : base(options)
        {

        }

        public DbSet<AsianFood> AsianFood { get; set; }
    }
}