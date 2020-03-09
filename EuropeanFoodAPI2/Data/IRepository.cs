using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EuropeanFoodAPI.Data
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetBycountry(string country);
    }
}
