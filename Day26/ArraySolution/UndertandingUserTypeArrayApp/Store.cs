using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndertandingUserTypeArrayApp
{
    internal class Store
    {
        Pizza[] pizzas;
        public Store()
        {
            Console.WriteLine("Welcome to the Store opening!!1");
            Console.WriteLine("How amny pizzas you wanna stock?");
            int count = Convert.ToInt32(Console.ReadLine());
            pizzas = new Pizza[count];//initializes the array size. An array of null reff is created
        }
        public void AddPizzas()
        {
            for (int i = 0; i < pizzas.Length; i++) 
            { 
                pizzas[i]= new Pizza();//create a object for teh reff
                pizzas[i].TakePizzaDetails();//popluate the object
            }
        }
        public void PrintPizzas()
        {
            for (int i = 0; i < pizzas.Length; i++)
            {
                pizzas[i].PrintPizzaDetails();
            }
        }
    }
}
