using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaBLLibrary
{
    public interface IShopping
    {
        Pizza[] GetPizzas();
        bool AddToCart(Pizza pizza);
        Pizza[] Checkout();
    }
}
