using FirstAPI.Interfaces;
using FirstAPI.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace FirstAPI.Services
{
    public class ProductRepo : IRepo<int, Product>
    {
        static IList<Product> products = new List<Product>()
        {
            new Product { Id = 101,Name="Pencil",Price=12.5f,Quantity=2},
            new Product { Id = 102,Name="Eraser",Price=5.0f,Quantity=3}
        };
        public Product Add(Product item)
        {
            if (products.Contains(item)) 
                return null;
            products.Add(item);
            return item;
        }

        public Product Delete(int key)
        {
            Product product = Get(key);
            if (product != null)
            {
                products.Remove(product);
                return product;
            }
            return null;
        }

        public Product Get(int key)
        {
           Product product = products.SingleOrDefault(p=>p.Id == key);
            return product;
        }

        public ICollection<Product> GetAll()
        {
            if(products.Count != 0)
                return products;
            return null;
        }

        public Product Update(Product item)
        {
            Product product = Get(item.Id);
            if (product != null)
            {
                product.Name = item.Name;
                product.Price = item.Price;
                product.Quantity = item.Quantity;
                return product;
            }
            return null;
        }
    }
}
