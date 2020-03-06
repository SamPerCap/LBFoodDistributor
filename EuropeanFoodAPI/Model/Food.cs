using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EuropeanFoodAPI.Model
{
    public class Food
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
    }
}
