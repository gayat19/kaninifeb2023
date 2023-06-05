using FirstAPI.Interfaces;
using FirstAPI.Models.DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    [EnableCors("MyCors")]
    public class CartController : ControllerBase
    {
        private readonly ICarting _carting;

        public CartController(ICarting carting)
        {
            _carting = carting;
        }
        [HttpGet]
        public async Task<ActionResult<ICollection<CartProduct>>> Get()
        {
            return Ok(await _carting.GetAll());
        }
    }
}
