using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingInheritanceApp
{
    internal class Shop
    {
        public void Sell(Pizza p2)
        {
            p2.PrintPizzaDetails();
            Console.WriteLine("Do you want to buy??");
        }
        public Pizza MakePizza()
        {
            Pizza p1 = new Pizza();
            p1.TakePizzaDetails();//using a behaviour to populate the object
            return p1;
        }
    }
}
