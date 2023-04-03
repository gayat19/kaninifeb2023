using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingExcepionApp
{
    public class InvalidAgeException: Exception
    {
        string message;
        public InvalidAgeException() {
            message = "Not a valid age";
        }
        public InvalidAgeException(string message)
        {
            this.message = message;
        }
        public override string Message
        {
            get { return message; }
        }
    }
}
