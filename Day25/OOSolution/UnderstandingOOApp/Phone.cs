using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOApp
{
    internal class Phone
    {
        //public string Color;//void direct public variables
        //private string colour;
        //public void SetColour(string clr)
        //{
        //    colour = clr;
        //}
        //public string GetColour()
        //{
        //    return colour;
        //}
        //public string Colour { get; set; }
        public string Colour { get; set; }
        public void PhoneCalling()//Behaviour
        {
            Console.WriteLine("Your phone whis is "+Colour+" in colour is Tring tringin");
        }
    }
}
