using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingIndexerApp
{
    internal class Pizza
    {
        public string[] toppings ;

        public string this[int index]
        {
            get { return toppings[index]; }
            set { toppings[index] = value; }
        }
        /// <summary>
        /// Default constructor that will initialize the topping size to 5
        /// </summary>
        public Pizza()
        {
            toppings = new string[5];
        }
        /// <summary>
        /// Except tpping all the properties have to taken in
        /// </summary>
        /// <param name="toppingCount">This will be the number of toppings you can add</param>
        public Pizza(int toppingCount)
        {
            toppings = new string[toppingCount];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="price">Price of teh pizza in INR</param>
        /// <param name="name">Name of the pizza for order</param>
        /// <param name="id">An Unique ID for the pizza</param>

        public Pizza(double price, string? name, int id):this()
        {
            Price = price;
            Name = name;
            Id = id;
        }
        /// <summary>
        /// All in one
        /// </summary>
        /// <param name="price"></param>
        /// <param name="name"></param>
        /// <param name="id"></param>
        /// <param name="toppingCount"></param>
        public Pizza(double price, string? name, int id, int toppingCount):this(price, name, id)
        {
            toppings = new string[toppingCount];
        }

        public double Price { get; set; }
        public string? Name { get; set; }
        public int Id { get; set; }

        private void TakeDetails()
        {
            Console.WriteLine("Please enter the Pizza Name");
            Name = Console.ReadLine();
            Console.WriteLine("Please enter the Pizza Price");
            Price = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many toppings do you like to add??");
            int toppingsCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the toppings");
            for (int i = 0; i < toppingsCount && i < 5; i++)
            {
                toppings[i] = Console.ReadLine();
            }
        }

        public void TakePizzaDetails()
        {
            Console.WriteLine("Please enter the Pizza Id");
            Id = Convert.ToInt32(Console.ReadLine());
            TakeDetails();
        }

        public void TakePizzaDetails(int id)
        {
            Id = id;
            TakeDetails();
        }

        public void PrintPizzaDetails()
        {
            Console.WriteLine("Pizza Details");
            Console.WriteLine($"Pizza Id : {Id}");//Interpollation
            Console.WriteLine($"Pizza name : {Name}");//Interpollation
            Console.WriteLine($"Pizza price : Rs.{Price}");//Interpollation
            int count = 0;
            while (toppings[count] != null)
            {
                Console.WriteLine($"Topping {count} {toppings[count]}");
                count++;
            }
        }
    }
}
