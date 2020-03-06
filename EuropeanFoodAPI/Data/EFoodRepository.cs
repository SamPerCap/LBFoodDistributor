using EuropeanFoodAPI.Model;
using System;
using System.Collections.Generic;

namespace EuropeanFoodAPI.Data
{
    public class EFoodRepository : IRepository<Food>
    {
        private readonly EFoodApiContext context;

        public EFoodRepository(EFoodApiContext ctx)
        {
            context = ctx;
        }

        public IEnumerable<Food> GetAll()
        {
            throw new NotImplementedException();
        }

        public Food GetBycountry(string country)
        {
            throw new NotImplementedException();
        }
    }
}
