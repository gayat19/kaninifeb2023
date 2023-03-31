using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelLibrary
{
    public class StorePizza :Pizza
    {
        public int Quantity { get; set; }
        public override string ToString()
        {
            return base.ToString()+"\nQuantity : "+Quantity;
        }
        protected override void TakeDetails()
        {
            base.TakeDetails();
            Console.WriteLine("Please enter the quantity");
            int quantity = 0;
            while(!int.TryParse(Console.ReadLine(), out quantity) && quantity>0)
            {
                Console.WriteLine("Invalid entry for quantity. Try again giving a positive integer");
            }
            Quantity = quantity;
        }
    }
}
