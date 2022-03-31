using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Catalog.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Catalog.Data;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly CatalogDbContext _db;
        private static Category category = new Category { Name = "Phones", Id = 1, Description = "Calling devices" };
        private static readonly Product[] Products = new Product[]
        {
            new Product { Name = "iPhone", Description="One minded phone cult", Id=1, Category = category, CategoryId=category.Id},
            new Product { Name = "Android", Description="Advance users", Id=2, Category = category, CategoryId=category.Id},
            new Product { Name = "Windows Phone", Description="Awesome phone badly marketed and ultimately failed, extinct", Id=3, Category = category, CategoryId=category.Id}
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger, CatalogDbContext dbContext)
        {
            _logger = logger;
            _db = dbContext;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _db.Products.ToList();
        }

        [HttpPost]
        public async Task<IActionResult> Post(Product product)
        {

            try
            {
                Category category = product.Category;
              _db.Categories.Add(category);
              
              product.CategoryId = category.Id;
               
               
               _db.Products.Add(product);

                await _db.SaveChangesAsync();
                return Ok(product);

            }
            catch (Exception e)
            {
                _logger.LogError(e?.Message ?? e?.InnerException?.Message);
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

        }
    }
}
