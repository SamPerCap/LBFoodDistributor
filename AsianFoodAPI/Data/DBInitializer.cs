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
                    Name = "DonkeyKong Dish",
                    Continent = "Asia",
                    Country = "Japan",
                    Ingredients = new List<string>()
                    {
                        "Sam Souce",
                        "Amazing Sam Pineapple",
                        "Crazy Sam BBQ"
                    }
                }
            };

            context.AsianFood.AddRange(food);
            context.SaveChanges();
        }
    }
}
