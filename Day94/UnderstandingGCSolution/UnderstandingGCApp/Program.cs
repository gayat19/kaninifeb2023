namespace UnderstandingGCApp
{
    internal class Program
    {
        void PizzaSaapdu()
        {
            using Pizza pizza = new Pizza();
            //pizza = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            new Program().PizzaSaapdu();
            Console.WriteLine("Done and Dusted");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.WriteLine("End of main");

        }
    }
}