using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstAPI.Controllers
{
    //[Route("api/[controller]/[Action]")]
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string SayHello()
        {
            return "Hello";
        }
        //[HttpGet]
        //public string SayHi()
        //{
        //    return "Hi";
        //}
        [HttpPost]
        public string AnotherMethod()
        {
            return "From the post";
        }
    }
}
