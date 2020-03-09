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
    [Route("api/EFood2")]
    public class EuropeanFood2Controller : Controller
    {
        private readonly IRepository<Food> repository;

        public EuropeanFood2Controller(IRepository<Food> repos)
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