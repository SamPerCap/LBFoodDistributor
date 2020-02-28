using LBFoodDistributor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBFoodDistributor
{
    public class EuropeanFood
    {
        List<Food> ListOfEuropeanFood = new List<Food>
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

    }
}
