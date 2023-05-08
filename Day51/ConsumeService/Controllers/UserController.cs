using ConsumeService.Interfaces;
using ConsumeService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeService.Controllers
{
    public class UserController : Controller
    {
        private readonly IUser _userService;

        public UserController(IUser userService)
        {
            _userService = userService;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var myUser = await _userService.Login(user);
            if(myUser == null)
            {
                ViewBag.Error = "Invalid username or password";
                return View();
            }
            else
            {
                HttpContext.Session.SetString("token", myUser.Token);
                return RedirectToAction("Index", "Home");
            }
               
        }
    }
}
