using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using W2BK6M_WebAPI.Models;

namespace W2BK6M_WebAPI.Controllers
{
    //[Route("api/[controller]")]
    //[ApiController]
    public class DatabaseController : ControllerBase
    {
        [HttpGet]
        [Route("databse/customer")]
        public IActionResult M1()
        {
            CustomerContext context = new CustomerContext();
            var adatok = from x in context.Customers
                         select x;
            return Ok(adatok);
        }

        [HttpGet]
        [Route("databse/order")]
        public IActionResult M2()
        {
            CustomerContext context = new CustomerContext();
            var adatok = from x in context.Orders
                         select x;
            return Ok(adatok);
        }

        [HttpGet]
        [Route("databse/item")]
        public IActionResult M3()
        {
            CustomerContext context = new CustomerContext();
            var adatok = from x in context.Items
                         select x;
            return Ok(adatok);
        }
    }
}
