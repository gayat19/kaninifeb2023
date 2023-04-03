using System.Diagnostics;

namespace UnderstandingExcepionApp
{
    internal class Program
    {
        void SimpleMethod()
        {
            int num1 = 0, num2 = 0, result=0;
            try
            {
                try
                {
                    Console.WriteLine("Please enter the first number");
                    num1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter the Second number");
                    num2 = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("Invalid input for number");
                    Debug.WriteLine(fe.Message);
                }
                result = num1 / num2;
                Console.WriteLine("The result is "+result);
            }
            catch (ArithmeticException ae)
            {
                Console.WriteLine("Cannot divide by zero. Please start over and enter the second number > 0 ");
                Debug.WriteLine(ae.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Something went wrong. Sorry. Have to end.");
            }
            finally{
                Console.WriteLine("Bye");
            }
        }
        void UnderstandingCUstomExceptions()
        {
            int age = 0;
            try
            {
                Console.WriteLine("Please ener teh age");
                age = Convert.ToInt32(Console.ReadLine());
                if(age<18)
                    throw new InvalidAgeException("the entered age is "+age+" but has to be above 18");
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid input for number");
                Debug.WriteLine(fe.Message);
            }
            catch(InvalidAgeException iae)
            {
                Console.WriteLine("Age has to be above 18");
                Debug.WriteLine(iae.Message);
            }

        }
        static void Main(string[] args)
        {
            new Program().UnderstandingCUstomExceptions();
            
        }
    }
}