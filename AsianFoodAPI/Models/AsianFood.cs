using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianFoodAPI.Models
{
    public class AsianFood
    {
        public string Name { get; set; }
        public IList<string> Ingredients { get; set; }
        public string Country { get; set; }
        public string Continent { get; set; }
    }
}
