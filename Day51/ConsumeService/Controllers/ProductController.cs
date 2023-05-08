using ConsumeService.Interfaces;
using ConsumeService.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsumeService.Controllers
{
    public class ProductController : Controller
    {
        private readonly IManageProduct _productService;

        public ProductController(IManageProduct manageProduct)
        {
            _productService = manageProduct;   
        }

        public async Task<IActionResult> Index()
        {
            string token = HttpContext.Session.GetString("token");
            if (token != null && token != "")
            {
                _productService.SetToken(token);
                IList<Product> products = (await _productService.GetAll()).ToList();
                return View(products);
            }
           
            return RedirectToAction("Login","User");
        }
    }
}
