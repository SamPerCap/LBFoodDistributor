using LBFoodDistributor.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace LBFoodDistributor
{
    public interface ICRUD
    {
        IEnumerable<Food> GetAll();
        IEnumerable<Food> GetByContinent(string Continent);
        IEnumerable<Food> GetByCountry(string Country);

    }
}
