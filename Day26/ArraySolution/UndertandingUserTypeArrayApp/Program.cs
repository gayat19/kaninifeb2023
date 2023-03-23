namespace UndertandingUserTypeArrayApp
{
    internal class Program
    {
        Store store;
        public Program()
        {
            store = new Store();
        }
        public void ManageStore()
        {
            store.AddPizzas();
            store.PrintPizzas();
        }
        static void Main(string[] args)
        {
            new Program().ManageStore();
        }
    }
}