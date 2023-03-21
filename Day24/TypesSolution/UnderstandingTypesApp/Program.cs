using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingTypesApp
{
    class Program
    {
        static int number1, number2;
        static void TakeTwoNumbers()
        {
            Console.WriteLine("Please enter the first number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            number2 = Int32.Parse(Console.ReadLine());
        }
        private static void Add()
        {
            int sum = number1 + number2;
            Console.WriteLine("The sum of " + number1 + " and " + number2 + " is " + sum);
            //Console.WriteLine("The sum of {0} and {1} is {2}", number1, number2, sum);
        }
        static void Main(string[] args)
        {
            TakeTwoNumbers();
            Add();
            Console.ReadKey();
        }

        
    }
}
