using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Runtime.ConstrainedExecution;

namespace EFSampleApp
{
    internal class Program
    {
        CenimaContext context = new CenimaContext();
        void AddCustomer()
        {
            Customer customer = new Customer() { Age = 26, Name = "Himu", Phone = "4321098765" };
            Console.WriteLine("Before add "+context.Entry(customer).State);
            context.Customers.Add(customer);
            Console.WriteLine("After add " + context.Entry(customer).State);
            // Console.WriteLine("After Add " + context.Customers.Count());
            context.SaveChanges();
            Console.WriteLine("After save chanegs " + context.Entry(customer).State);
            // Console.WriteLine("After Save changes" + context.Customers.Count());

        }
        void UpdateCustomer()
        {
            Customer customer = context.Customers.SingleOrDefault(c => c.Id == 1);
            Console.WriteLine("After get" + context.Entry(customer).State);
            Console.WriteLine("Please enter the new name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("After edit " + context.Entry(customer).State);
            context.SaveChanges();
            Console.WriteLine("After save chanegs " + context.Entry(customer).State);
            Console.WriteLine("Updated");
        }
        void PrintCustomers()
        {
            var customers = context.Customers;
            foreach (var customer in customers)
            {
                Console.WriteLine(customer);
            }
        }
        void DeleteCustomer()
        {
            Customer customer = context.Customers.SingleOrDefault(c => c.Id == 5);
            Console.WriteLine("After get " + context.Entry(customer).State);
            context.Customers.Remove(customer);
            Console.WriteLine("After remove" + context.Entry(customer).State);
            context.SaveChanges();
            Console.WriteLine("After save chanegs " + context.Entry(customer).State);
            Console.WriteLine("Deleted");
        }
        void PrintMovies()
        {
            var movies = context.Movies;
            foreach (var movie in movies)
            {
                Console.WriteLine(movie);
            }
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            //program.AddCustomer();
            //program.UpdateCustomer();
            program.DeleteCustomer();
            //program.PrintCustomers();
            Console.WriteLine("Hello, World!");
        }
    }
}