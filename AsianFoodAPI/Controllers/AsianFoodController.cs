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
    public class AsianFoodController : Controller
    {
        private readonly IAsianFoodRepository _asianFoodRepo;
        public AsianFoodController(IAsianFoodRepository asianFoodRepo)
        {
            _asianFoodRepo = asianFoodRepo;
        }

        // GET: api/<controller>
        [HttpGet]
        public ActionResult<IEnumerable<AsianFood>> Get()
        {
            return Ok(_asianFoodRepo.GetAllFood().ToList());
        }
    }
}