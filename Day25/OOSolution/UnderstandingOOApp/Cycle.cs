using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingOOApp
{
    internal class Cycle
    {
       
        public int NumberOfWheels { get; set; }
        public float Speed { get; set; }
        public string  Make { get; set; }
        public Cycle()
        {

        }
        public Cycle(int numberOfWheels, float speed, string make)
        {
            NumberOfWheels = numberOfWheels;
            Speed = speed;
            Make = make;
        }
        public void Horn()
        {
            Console.WriteLine("Tring tring");
        }
        public void Pedal()
        {
            Speed = 20;
            Console.WriteLine("Press and go.. repead");
        }
        public void Run()
        {
            Console.WriteLine(Make +" Runs in the speed of "+Speed);
        }
        public void Stop()
        {
            Console.WriteLine("kreech.... Stoped");
            Speed = 0;
        }
    }
}
