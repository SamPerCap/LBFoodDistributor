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

            List<Food> foodList = new List<Food>
            {
                new Food
            {
                Name = "Paella",
                Country = "Spain",
                Continent = "Europe",
                MainIngredient = "Rice"
            },
            new Food
            {
                Name = "Pizza",
                Country = "Italy",
                Continent = "Europe",
                MainIngredient = "Tomato"
            },
            new Food
            {
                Name = "Hakarl",
                Country = "Island",
                Continent = "Europe",
                MainIngredient = "Shark"
            },
            new Food
            {
                Name = "Quiche Lorraine",
                Country = "France",
                Continent = "Europe",
                MainIngredient = "Eggs"
            },
            new Food
            {
                Name = "Money",
                Country = "Netherlands",
                Continent ="Europe",
                MainIngredient = "Spices"
            }
            };

            context.EuropeanFood.AddRange(foodList);
            context.SaveChanges();
        }
    }
}
