namespace UnderstandingIndexerApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Pizza pizza = new Pizza();
            ////pizza.toppings[0] = "Olives";
            //pizza[0] = "Onions";
            //Console.WriteLine(pizza[0]);

            Store dominos = new Store();
            dominos.AddPizzas();
            dominos.PrintPizzas();
        }
    }
}