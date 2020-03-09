using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EuropeanFoodAPI.Data;
using EuropeanFoodAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace EuropeanFoodAPI.Controllers
{
    [Route("api/EFood")]
    public class EuropeanFoodController : Controller
    {
        private readonly IRepository<Food> repository;

        public EuropeanFoodController(IRepository<Food> repos)
        {
            repository = repos;
        }

        // GET: api/EFood
        [HttpGet]
        public IEnumerable<Food> Get()
        {
            return repository.GetAll();
        }

    }
}