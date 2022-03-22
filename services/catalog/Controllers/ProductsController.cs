using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Catalog.DTOs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private static Category category = new Category { Name = "Phones", Id = 1, Description = "Calling devices" };
        private static readonly Product[] Products = new Product[]
        {
            new Product { Name = "iPhone", Description="One minded phone cult", Id=1, Category = category, CategoryId=category.Id},
            new Product { Name = "Android", Description="Advance users", Id=2, Category = category, CategoryId=category.Id},
            new Product { Name = "Windows Phone", Description="Awesome phone badly marketed and ultimately failed, extinct", Id=3, Category = category, CategoryId=category.Id}
        };

        private readonly ILogger<ProductsController> _logger;

        public ProductsController(ILogger<ProductsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            var rng = new Random();

            // return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            // {
            //     Date = DateTime.Now.AddDays(index),
            //     TemperatureC = rng.Next(-20, 55),
            //     Summary = Products[rng.Next(Products.Length)]
            // })
            // .ToArray();
            return Products;
        }
    }
}
