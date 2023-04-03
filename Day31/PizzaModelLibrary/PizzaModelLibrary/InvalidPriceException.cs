using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaModelLibrary
{
    public class InvalidPriceException :Exception
    {
        string message;
        public InvalidPriceException()
        {
            message = "Price has to be greater than 1";
        }
        public override string Message => message;
    }
}
