using JWTAuthenticationExample.Interfaces;
using JWTAuthenticationExample.Models;

namespace JWTAuthenticationExample.Services
{
    public class ProductService
    {
        private readonly IRepo<int, Product> _repo;

        public ProductService(IRepo<int,Product> repo) 
        { 
            _repo = repo;
        }
        public List<Product> GetProductsByPrice(int min,int max) 
        {
            if (max < min)
                return null;
            List<Product> products = _repo.GetAll().ToList();
            products = products.Where(p=>p.Price>=min && p.Price<=max).ToList();
            return products;
        }
    }
}
