using JWTAuthenticationExample.Models.DTO;
using JWTAuthenticationExample.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationExample.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class UserController : ControllerBase
    {
        private readonly UserService _service;

        public UserController(UserService service) 
        {
            _service = service;
        }
        [HttpPost]
        public ActionResult<UserDTO> Register([FromBody] UserRegisterDTO userDTO)
        {
            var user = _service.Register(userDTO);
            if (user == null)
            {
                return BadRequest("Unable to register");
            }
            return Created("Home", user);
        }
        [HttpPost]
        public ActionResult<UserDTO> Login([FromBody] UserDTO userDTO)
        {
            var user = _service.Login(userDTO);
            if (user == null)
            {
                return BadRequest("Invalid username or password");
            }
            return Ok(user);
        }
    }
}
