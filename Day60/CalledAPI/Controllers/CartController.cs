using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalledAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        List<Cart> cart = new List<Cart>()
        {
            new Cart{Products=new List<int>{101,103},Quantity= new List<int>{1,1 } },
             new Cart{Products=new List<int>{101},Quantity= new List<int>{3 } },
        };
        [HttpGet]
        public async Task<ActionResult<List<Cart>>> Get()
        {
            return Ok(cart);
        }
    }
    public class Cart
    {
        public List<int> Products { get; set; }
        public  List<int> Quantity { get; set; }
    }
}
