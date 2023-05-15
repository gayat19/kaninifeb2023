using FirstAPI.Interfaces;
using FirstAPI.Models;
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
    public class ProductController : ControllerBase
    {
        private readonly IRepo<int, Product> _repo;

        public ProductController(IRepo<int,Product> repo) 
        {
            _repo = repo;
        }
        [HttpGet]
        [ProducesResponseType(typeof(ICollection<Product>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<ICollection<Product>> Get()
        {
            IList<Product> products = _repo.GetAll().ToList();
            if (products == null)
                return NotFound("No products availbile at this moment");
            return Ok(products);
        }
        [HttpGet("GetById")]
        [ProducesResponseType(typeof(ICollection<Product>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = _repo.Get(id);
            if (product == null)
                return NotFound("No Product with the given ID");
            return Ok(product);
        }
        [HttpPost]
        [ProducesResponseType(typeof(Product), StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product>Add(Product product)
        {
            Product newProduct = _repo.Add(product);
            if (newProduct == null)
                return BadRequest(new Error(1,"Unable toa add product"));
            return Created("Product Added",newProduct);
        }
        [HttpPut]
        [ProducesResponseType(typeof(ICollection<Product>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> Edit(int id,Product product)
        {
            Product newProduct = _repo.Get(id);
            if (newProduct == null)
                return NotFound(new Error(2, "No such product is present"));
            newProduct= _repo.Update(product);
            if (newProduct == null)
                return BadRequest(new Error(1, "Unable to update product info"));
            return Ok(newProduct);
        }
        [HttpDelete]
        [ProducesResponseType(typeof(ICollection<Product>), 200)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<Product> Delete(int id)
        {
            Product newProduct = _repo.Get(id);
            if (newProduct == null)
                return NotFound(new Error(2, "No such product is present"));
            newProduct = _repo.Delete(id);
            if (newProduct == null)
                return BadRequest(new Error(1, "Unable to delete product"));
            return Ok(newProduct);
        }
    }
}
