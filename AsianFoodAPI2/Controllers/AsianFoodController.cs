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
        private readonly IRepository<AsianFood> _asianFoodRepo;
        public AsianFoodController(IRepository<AsianFood> asianFoodRepo)
        {
            _asianFoodRepo = asianFoodRepo;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<AsianFood>> Get()
        {
            return Ok(_asianFoodRepo.GetAll().ToList());
        }
    }
}