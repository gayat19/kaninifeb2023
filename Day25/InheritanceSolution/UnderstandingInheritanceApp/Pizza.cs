using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApp
{
    internal class Pizza
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public int Id { get; set; }

        public void TakePizzaDetails()
        {
            Console.WriteLine("Please enter the Pizza Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the Pizza Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the Pizza Price");
            Price = Convert.ToDouble(Console.ReadLine());
        }
        public void PrintPizzaDetails()
        {
            Console.WriteLine("Pizza Details");
            Console.WriteLine($"Pizza {{Id}} : {Id}");//Interpollation
            Console.WriteLine($"Pizza name : {Name}");//Interpollation
            Console.WriteLine($"Pizza price : Rs.{Price}");//Interpollation
        }
    }
}
