using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOverridingApp
{
    internal class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Munch munch");
        }
        public void Sleep()
        {
            Console.WriteLine("zzzzzzzzzzz");
        }
        public virtual void Move()
        {
            Console.WriteLine("Animals do go from one place to another");
        }
    }
}
