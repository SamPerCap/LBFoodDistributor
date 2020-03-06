using AsianFoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianFoodAPI.Data
{
    public class DBInitializer : IDBInitializer
    {
        public void Initialize(AsianFoodContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            // Look for any Orders
            if (context.AsianFood.Any())
            {
                return;   // DB has been seeded
            }

            List<AsianFood> food = new List<AsianFood>
            {
                new AsianFood {
                    Id = 1,
                    Name = "DonkeyKong Dish",
                    Continent = "Asia",
                    Country = "Japan",
                }
            };

            List<AsianFood> food2 = new List<AsianFood>
            {
                new AsianFood {
                    Id = 2,
                    Name = "AmazingSam",
                    Continent = "Asia",
                    Country = "China",
                }
            };

            List<AsianFood> food3 = new List<AsianFood>
            {
                new AsianFood {
                    Id = 3,
                    Name = "ChinLinSam",
                    Continent = "Asia",
                    Country = "India",
                }
            };

            context.AsianFood.AddRange(food);
            context.AsianFood.AddRange(food2);
            context.AsianFood.AddRange(food3);
            context.SaveChanges();
        }
    }
}
