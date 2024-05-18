using Microsoft.AspNetCore.Mvc;
using SimpleApi.Models;
using System.Collections.Generic;

namespace SimpleApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomersController : ControllerBase
    {
        private static readonly List<Customer> Customers = new List<Customer>();

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            return Customers;
        }

        [HttpPost]
        public ActionResult<Customer> Post(Customer customer)
        {
            Customers.Add(customer);
            return customer;
        }
    }
}
