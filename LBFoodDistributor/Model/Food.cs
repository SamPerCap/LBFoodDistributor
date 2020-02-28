using System;
using System.Collections.Generic;
using System.Text;

namespace LBFoodDistributor.Model
{
    public class Food
    {
        public string Name { get; set; }
        public List<string> Ingredients { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
    }
}
