using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EuropeanFoodAPI.Model
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MainIngredient { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
    }
}
