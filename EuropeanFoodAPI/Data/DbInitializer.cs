using EuropeanFoodAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EuropeanFoodAPI.Data
{
    public class DbInitializer : IDbInitializer
    {
        public void Initialize(EFoodApiContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.EuropeanFood.Any())
            {
                return;
            }

            IEnumerable<Food> products = new List<Food>
            {
                new Food
            {
                Name = "Paella",
                Country = "Spain",
                Continent = "Europe",
                Ingredients = {"Rice", "Chicken", "Mussel", "Squid"}
            },
            new Food
            {
                Name = "Pizza",
                Country = "Italy",
                Continent = "Europe",
                Ingredients = {"Cheese", "Ham", "Tomato", "Basil"}
            },
            new Food
            {
                Name = "Hakarl",
                Country = "Island",
                Continent = "Europe",
                Ingredients = {"Shark", "Hate", "Kris", "Help"}
            },
            new Food
            {
                Name = "Quiche Lorraine",
                Country = "France",
                Continent = "Europe",
                Ingredients = {"Eggs", "Cream", "Ham", "Hope"}
            },
            new Food
            {
                Name = "Money",
                Country = "Netherlands",
                Continent ="Europe",
                Ingredients = {"Bank", "Euro", "Dutch" , "Amsterdam"}
            }
            };

            context.EuropeanFood.AddRange(products);
            context.SaveChanges();
        }
    }
}
