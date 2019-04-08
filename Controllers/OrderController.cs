using tshirts.Models;
using Microsoft.AspNetCore.Mvc;

namespace tshirts.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class OrdersController : ControllerBase
  {
    [HttpPost]
    public ActionResult<Receipt> NewOrder([FromBody] Order order)
    {
      // backend check inventory, etc.
      return new Receipt(order);
    }
  }
}