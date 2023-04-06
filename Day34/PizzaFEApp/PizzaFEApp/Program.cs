namespace PizzaFEApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaProvider provider = new PizzaProvider();
            provider.AddPizza();
            provider.PiringAllPizza();
        }
    }
}