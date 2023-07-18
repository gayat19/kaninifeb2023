using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingGCApp
{
    public class Pizza:IDisposable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Topping> Toppings { get; set; }
        public Pizza()
        {
            Console.WriteLine("Pizza created");
            Toppings = new List<Topping>();
        }
        ~ Pizza()
        { 
            Console.WriteLine("Pizza lam saaptachu.");
        }

        public void Dispose()
        {
            Console.WriteLine("Pizza in kuppai thotti");
        }
    }
}
