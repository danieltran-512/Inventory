using Inventory.Models;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.Controllers
{
    [ApiController]
    [Route("orders")]
    public class OrderController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(List<Part> parts)
        {
            try
            {
                List<LineItem> LineItems = new List<LineItem>();

                parts.ForEach(part => LineItems.Add(new LineItem(part)));

                Order Order = new Order(LineItems);

                return Ok(Order);
            }
            catch
            {
                return NotFound();
            }
        }
    }
}

