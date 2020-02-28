using LBFoodDistributor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBFoodDistributor
{
    class EuropeanCRUD : ICRUD
    {
        public IEnumerable<Food> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Food> GetByContinent(string Continent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Food> GetByCountry(string Country)
        {
            throw new NotImplementedException();
        }
    }
}
