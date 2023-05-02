using FirstAPI.Interfaces;
using FirstAPI.Models;
using System.Diagnostics;

namespace FirstAPI.Services
{
    public class ProductRepoEF : IRepo<int, Product>
    {
        private readonly ShopContext _context;

        public ProductRepoEF(ShopContext context)
        {
            _context = context;
        }
        public Product Add(Product item)
        {
            try
            {
                _context.Products.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

        public Product Delete(int key)
        {
            try
            {
                var product = Get(key);
                if(product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                    return product;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }

        public Product Get(int key)
        {
             var product = _context.Products.SingleOrDefault(p=>p.Id==key);
            return product;
        }

        public ICollection<Product> GetAll()
        {
            var products = _context.Products.ToList();
            if(products.Count >0)
                return products;
            return null;
        }

        public Product Update(Product item)
        {
            try
            {
                var product = Get(item.Id);
                if (product != null)
                {
                    product.Name = item.Name;
                    product.Price = item.Price;
                    product.Quantity = item.Quantity;
                    _context.SaveChanges();
                    return product;
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return null;
        }
    }
}
