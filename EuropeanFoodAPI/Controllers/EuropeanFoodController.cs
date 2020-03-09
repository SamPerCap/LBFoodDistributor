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
        Random random = new Random();
        int isDown;
        private readonly IRepository<Food> repository;

        public EuropeanFoodController(IRepository<Food> repos)
        {
            repository = repos;
        }

        // GET: api/EFood
        [HttpGet]
        public ActionResult<IEnumerable<Food>> Get()
        {
            isDown = random.Next(4);
            // 0 means the server is down.
            // 1 means the server is up.

            if (isDown == 0)
                return NotFound();
            else
                return Ok(repository.GetAll().ToList());
        }

    }
}