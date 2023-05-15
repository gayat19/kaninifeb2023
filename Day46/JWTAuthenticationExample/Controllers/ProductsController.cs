using JWTAuthenticationExample.Interfaces;
using JWTAuthenticationExample.Models;
using JWTAuthenticationExample.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTAuthenticationExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("MyCors")]
    public class ProductsController : ControllerBase
    {
        private readonly IRepo<int, Product> _repo;
        private readonly ProductService _productService;

        public ProductsController(IRepo<int,Product> repo,ProductService service)
        {
            _repo = repo;
            _productService = service;
        }
       
        [HttpGet]
        public ActionResult<List<Product>> Get(int min,int max) 
        { 
            List<Product> products = _productService.GetProductsByPrice(min, max);
            if (products != null)
                return Ok(products);
            return NotFound("No products in this range");
        }
        [Authorize]
        [HttpPost]
        
        public ActionResult<Product> Post( Product product) 
        { 
            Product prod = _repo.Add(product);
            return Created("ProductListing",prod);
        }
    }
}
