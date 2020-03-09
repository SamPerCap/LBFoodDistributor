using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EuropeanFoodAPI.Data
{
    public interface IDbInitializer
    {
        void Initialize(EFoodApiContext context);
    }
}
