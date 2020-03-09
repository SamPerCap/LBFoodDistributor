using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AsianFoodAPI.Data;
using AsianFoodAPI.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AsianFoodAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AsianFoodController : Controller
    {
        Random random = new Random();
        int isDown;
        private readonly IRepository<AsianFood> _asianFoodRepo;
        public AsianFoodController(IRepository<AsianFood> asianFoodRepo)
        {
            _asianFoodRepo = asianFoodRepo;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<AsianFood>> Get()
        {
            isDown = random.Next(1);
            // 0 means the server is down.
            // 1 means the server is up.

            if (isDown == 0)
                return NotFound();
            else
                return Ok(_asianFoodRepo.GetAll().ToList());
        }
    }
}