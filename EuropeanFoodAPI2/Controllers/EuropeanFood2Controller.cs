using System;
using System.Collections.Generic;
using System.Linq;
using EuropeanFoodAPI.Data;
using EuropeanFoodAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;

namespace EuropeanFoodAPI.Controllers
{
    [Route("api/EFood")]
    public class EuropeanFood2Controller : Controller
    {
        Random random = new Random();
        int isDown;
        private readonly IRepository<Food> repository;

        public EuropeanFood2Controller(IRepository<Food> repos)
        {
            repository = repos;
        }

        // GET: api/EFood
        [HttpGet]
        public ActionResult<IEnumerable<Food>> Get()
        {
            isDown = random.Next(4);

            if (isDown == 0)
                return NotFound();
            else
                return Ok(repository.GetAll().ToList());
        }

    }
}