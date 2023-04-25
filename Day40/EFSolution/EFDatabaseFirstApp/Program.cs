using EFDatabaseFirstApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.SymbolStore;
using System.Security.Cryptography.X509Certificates;

namespace EFDatabaseFirstApp
{
    internal class Program
    {
        pubsContext context = new pubsContext();
        void GetPublishers()
        {
            //var publishers = context.Publishers.Where(p => p.Country == "USA");
            //var publishers = (from p in context.Publishers where p.Country=="USA" select p).ToList();
            //foreach (var publisher in publishers)
            //{
            //    Console.WriteLine(publisher.PubName);
            //}
            var authors = context.Authors.Include(a=>a.Titleauthors).ThenInclude(ta=>ta.Title);
            foreach (var auth in authors)
            {
                Console.WriteLine(auth.AuLname+" "+auth.AuFname);
                foreach (var author in auth.Titleauthors)
                {
                    Console.WriteLine("\t"+author.Title.Title1);
                }
            }
        }
        void CountLINQ()
        {
             var publishersCount = context.Publishers.Where(p => p.Country == "USA").Count();
            Console.WriteLine(publishersCount);
        }
        void OrderData()
        {

            //var publishers = context.Publishers.OrderBy(pub => pub.Country);
            var publishers = context.Publishers.OrderByDescending(pub => pub.Country);
            foreach (var publisher in publishers)
            {
                Console.WriteLine(publisher.PubName + " " + publisher.Country);
            }
        }
        void GroupByCheck()
        {
            var publishers = context.Publishers.ToList();
            var pubs = publishers.GroupBy(p => p.Country);
           
            foreach (var item in pubs)
            {
                Console.WriteLine(item.Key);
                foreach (var data in item)
                {
                    Console.WriteLine("\t"+data.PubName);
                }
            }
        }
        void JoinExample()
        {
             List<Product> products = new List<Product>
            {
            new Product { Name = "Cola", CategoryId = 0 },
            new Product { Name = "Tea", CategoryId = 0 },
            new Product { Name = "Apple", CategoryId = 1 },
            new Product { Name = "Kiwi", CategoryId = 1 },
            new Product { Name = "Carrot", CategoryId = 2 },
            };

            List<Category> categories = new List<Category>
            {
            new Category { Id = 0, CategoryName = "Beverage" },
            new Category { Id = 1, CategoryName = "Fruit" },
            new Category { Id = 2, CategoryName = "Vegetable" }
            };
            //var query = from product in products
            //            join category in categories on product.CategoryId equals category.Id
            //            select new { ProductName = product.Name, category.CategoryName };
            var query = products.Join(categories, 
                (p) => p.CategoryId,
                (c)=>c.Id, 
                (p, c) => new { ProductName=p.Name,CategoryName=c.CategoryName});

            foreach (var item in query)
            {
                Console.WriteLine($"{item.ProductName} - {item.CategoryName}");
            }
        }
        void UnderstandingInclude()
        {
            var publishers = context.Publishers.Include(p => p.Titles);
            foreach (var publisher in publishers)
            {
                Console.WriteLine(publisher.PubName);
                foreach (var title in publisher.Titles)
                {
                    Console.WriteLine("\t"+title.Title1);
                }
            }
        }
        void CheckAuthor()
        {
            Console.WriteLine("Please enter author first name");
            string fname = Console.ReadLine();
           Console.WriteLine("Please enter author last name");
            string lname = Console.ReadLine();
            Author author = context.Authors.SingleOrDefault(a => a.AuFname == fname && a.AuLname == lname);
            if(author == null)
                Console.WriteLine("Invalid username or password");
            else
                Console.WriteLine("Welcome "+author.AuFname+" "+author.AuLname);
        }
        static void Main(string[] args)
        {
            Program program = new Program();
           program.CheckAuthor();
           
        }
    }
   
    class Product
    {
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}