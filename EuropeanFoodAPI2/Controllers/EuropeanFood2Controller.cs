using System;
using System.Collections.Generic;
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
        public IEnumerable<Food> Get()
        {
            isDown = random.Next(0,1);
            // 0 means the server is down.
            // 1 means the server is up.

            if (isDown == 0)
                return null;
            else
                return repository.GetAll();
        }

    }
}