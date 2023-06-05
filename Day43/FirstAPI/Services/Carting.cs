using FirstAPI.Interfaces;
using FirstAPI.Models;
using FirstAPI.Models.DTO;

namespace FirstAPI.Services
{
    public class Carting : ICarting
    {
        HttpClient client;
        private readonly IRepo<int, Product> _repo;


        public Carting(IRepo<int,Product> repo)
        {
            client = new HttpClient();
            _repo = repo;   
        }
        public async Task<ICollection<CartProduct>> GetAll()
        {
            var result = await client.GetAsync("http://localhost:5092/api/Cart");
            if(result.IsSuccessStatusCode)
            {
                var data = await result.Content.ReadAsAsync<ICollection<Cart>>();
                List<CartProduct> cartProducts  = new List<CartProduct>();
                List<Product> products = _repo.GetAll().ToList();
                foreach (var cartItem in data)
                {
                    for(int i=0;i<cartItem.Products.Count; i++)
                    {
                        CartProduct product = new CartProduct();
                        product.ProductId = cartItem.Products[i];
                        product.ProductName = products.FirstOrDefault(p => p.Id == cartItem.Products[i]).Name;
                        product.Quantity = cartItem.Quantity[i];
                        cartProducts.Add(product);
                    }
                }
                return cartProducts; 
            }
            return null;
        }
    }
}
