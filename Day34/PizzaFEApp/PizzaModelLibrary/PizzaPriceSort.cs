using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelLibrary
{
    public class PizzaPriceSort : IComparer<Pizza>
    {
        public int Compare(Pizza? x, Pizza? y)
        {
            double price = x.Price ?? 0;
            return price.CompareTo(y.Price);
        }
    }
}
