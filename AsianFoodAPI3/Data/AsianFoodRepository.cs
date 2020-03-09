using AsianFoodAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsianFoodAPI.Data
{
    public class AsianFoodRepository : IRepository<AsianFood>
    {
        private readonly AsianFoodContext db;

        public AsianFoodRepository(AsianFoodContext context)
        {
            db = context;
        }

        public IEnumerable<AsianFood> GetAll()
        {
            return db.AsianFood.ToList();
        }
    }
}
