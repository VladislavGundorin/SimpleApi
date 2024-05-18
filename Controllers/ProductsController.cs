using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System.Collections.Generic;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static readonly List<Product> Products = new List<Product>();

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Products;
        }

        [HttpPost]
        public ActionResult<Product> Post(Product product)
        {
            Products.Add(product);
            return product;
        }
    }
}
