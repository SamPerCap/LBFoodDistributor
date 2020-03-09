using EuropeanFoodAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EuropeanFoodAPI.Data
{
    public class EFoodRepository : IRepository<Food>
    {
        private readonly EFoodApiContext context;

        public EFoodRepository(EFoodApiContext ctx)
        {
            context = ctx;
        }

        IEnumerable<Food> IRepository<Food>.GetAll()
        {
            return context.EuropeanFood.ToList();
        }

        public Food GetBycountry(string country)
        {
            throw new NotImplementedException();
        }
    }
}
