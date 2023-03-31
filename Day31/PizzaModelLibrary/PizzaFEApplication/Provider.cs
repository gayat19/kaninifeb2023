using PizzaBLLibrary;
using PizzaDALLibrary;
using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFEApplication
{
    internal class Provider
    {
        PizzaRepository pizzaRepository;
        IShopping managePizza;
        public Provider()
        {
            pizzaRepository = new PizzaRepository();
            InitializeStore();
            managePizza = new ManagePizza(pizzaRepository);//injecting the repository
            
        }
        private void InitializeStore()
        {
            int choice = 0;
            do
            {
                StorePizza pizza = new StorePizza();
                pizza.TakePizzaDetails();
                bool result;
                pizzaRepository.Add(pizza,out result);
                if(result )
                    Console.WriteLine("Pizza added successfully");
                else
                {
                    Console.WriteLine("We do not have a spot to insert the new pizza type");
                    break;
                }
                Console.WriteLine("Do you want to add another pizza");
                while(!int.TryParse(Console.ReadLine(),out choice))
                {
                    Console.WriteLine("Invalid entry please try again");
                }
            } while (choice!=0 );
        }
        void PrintMenu()
        {
            Console.WriteLine("Welcome to the Pizza Hat");
            Console.WriteLine("1. View available Pizzas");
            Console.WriteLine("2. Select a pizza to add to cart");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("0. Exit");
        }
        public void InteractWithStore()
        {
            int choice = 0;
            do
            {
                PrintMenu();
                Console.WriteLine("Select an option");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Bye bye. Shop again with us");
                        break;
                    case 1:
                        PrintPizzas();
                        break; 
                    case 2:
                        AddPizzaToCart();
                        break;
                    case 3:
                        BuyAndEat();
                         break;
                    default:
                        Console.WriteLine("Dont even know how to select from option. Get lost");
                        break;
                }

            } while (choice!=0);
        }

        private void BuyAndEat()
        {
            Console.WriteLine("Are you ready to check out??");
            string choice = Console.ReadLine().ToUpper();
            if (choice == "YES")
            {
                var pizzas = managePizza.Checkout();
                if(pizzas != null)
                {
                    double total = 0;
                    foreach (var item in pizzas)
                    {
                        if(item != null)
                        {
                            Console.WriteLine(item);
                            total += item.Price * ((StorePizza)item).Quantity;
                        }
                    }
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Total payable - "+total);
                }
            }
            else
                Console.WriteLine("Unable to check out. Sorry Start over again");

        }

        private void AddPizzaToCart()
        {
            int id;
            Console.WriteLine("Enter the pizza id to add to cart");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid entry please try again");
            }
            var pizza = pizzaRepository.Get(id);
            if(pizza == null)
            {
                Console.WriteLine("Do you know how to read and write????. Please wlk out");
                return;
            }
            Console.WriteLine("The pizza that you have selected is ");
            Console.WriteLine(pizza);
            StorePizza storePizza = new StorePizza();
            storePizza.Id = id;
            storePizza.Name = pizza.Name;
            storePizza.Price = pizza.Price;
            storePizza.toppings = pizza.toppings;
            storePizza.Quantity = 1;
            if(managePizza.AddToCart(storePizza))
                Console.WriteLine("Added to cart");
            else
                Console.WriteLine("You are shopping too much. No more pizza for you");

        }

        private void PrintPizzas()
        {
            var pizzas = managePizza.GetPizzas();
            if(pizzas != null )
            {
                for (int i = 0; i < pizzas.Length; i++)
                {
                    Console.WriteLine(pizzas[i]);
                    Console.WriteLine("------------------");
                }
            }
            Console.WriteLine("No Pizza for people with your name. Get out of teh store");
        }
    }
}
