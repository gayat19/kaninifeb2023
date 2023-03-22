using System;

namespace UnderstandingInheritanceApp
{
    internal class Program
    {
        static void Main(string[] g3)
        {
            Console.WriteLine("Hello World");
            Shop pizaHut = new Shop();
            Pizza p =pizaHut.MakePizza();
            pizaHut.Sell(p);
            Console.ReadKey();
           
        }
    }
}