using AsianFoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianFoodAPI.Data
{
    public interface IAsianFoodRepository
    {
        IEnumerable<AsianFood> GetAllFood();
    }
}
