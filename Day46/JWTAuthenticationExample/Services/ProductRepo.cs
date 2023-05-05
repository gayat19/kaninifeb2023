using JWTAuthenticationExample.Controllers;
using JWTAuthenticationExample.Interfaces;
using JWTAuthenticationExample.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JWTAuthenticationExample.Services
{
    public class ProductRepo:IRepo<int,Product>
    {
        private readonly JWTContext _context;

        public ProductRepo(JWTContext context)
        {
            _context = context;
        }

        public Product Add(Product item)
        {
            _context.Products.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Product Delete(int key)
        {
            Product item = Get(key);
            _context.Products.Remove(item);
            _context.SaveChanges();
            return item;
        }

        public Product Get(int key)
        {
           Product product = _context.Products.SingleOrDefault(p=>p.Id== key);
            return product;
        }

        public ICollection<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product Update(Product item)
        {
            Product product = _context.Products.SingleOrDefault(p => p.Id == item.Id);
            if(product != null)
            {
                product.Name = item.Name;
                product.Price = item.Price;
                product.Quantity = item.Quantity;
                _context.SaveChanges();
            }
            return product;
        }
    }
}
