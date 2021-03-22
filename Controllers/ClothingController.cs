using System.Collections.Generic;
using System.Linq;
using ClothesRUs.Contexts;
using ClothesRUs.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ClothesRUs.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClothingController : ControllerBase
    {
        private readonly ClothingContext _clothingContext;
        private readonly ILogger<ClothingController> _logger;

        public ClothingController(ClothingContext clothingContext, ILogger<ClothingController> logger)
        {
            _clothingContext = clothingContext;
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> GetClothes()
        {
            List<Product> clothes = _clothingContext.Products.ToList();

            return clothes;
        }
    }
}