using System.Collections.Generic;
using System.Runtime.InteropServices;
using ClothesRUs.Contexts;
using ClothesRUs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClothesRUs.Controllers
{
    [ApiController]
    [Route("clothing")]
    public class ClothingController
    {
        private readonly ClothingContext _clothingContext;
        private readonly ILogger<ClothingController> _logger;

        public ClothingController(ClothingContext clothingContext, ILogger<ClothingController> logger)
        {
            _clothingContext = clothingContext;
            _logger = logger;
        }

        [HttpGet]
        public List<Clothing> GetClothes()
        {
            List<Clothing> clothes = new List<Clothing>();
            
            return clothes;
        }
    }
}