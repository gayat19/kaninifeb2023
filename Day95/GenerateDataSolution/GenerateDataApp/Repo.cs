using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateDataApp
{
    public class Repo
    {
        Faker<Product> faker = new Faker<Product>()
                        .RuleFor(p => p.Id, fp => fp.IndexGlobal+1)
                        .RuleFor(p => p.Name, fp => fp.Commerce.ProductName())
                        .RuleFor(p => p.Quantity, fp => fp.Random.Int(10, 50))
                        .RuleFor(p => p.Price, fp => fp.Finance.Random.Float(1.5f, 10.5f));

        public List<Product>  GetAll()
        {
            return faker.Generate(10);
        }
        public void PrintProducts()
        {
            var products = GetAll();
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
