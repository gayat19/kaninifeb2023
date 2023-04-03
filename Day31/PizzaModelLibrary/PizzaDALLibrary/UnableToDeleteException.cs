using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALLibrary
{
    public class UnableToDeleteException:Exception
    {
        string message;
        public UnableToDeleteException()
        {
            message = "The pizza is in the order already. Unable to delete it";
        }
        public override string Message => message;
    }
}
