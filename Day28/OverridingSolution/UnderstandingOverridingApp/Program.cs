namespace UnderstandingOverridingApp
{
    internal class Program
    {
        void MakeForest(Animal animal)
        {
            animal.Eat();
            //((Monkey)animal).MonkeyMoves();
            animal.Move();
            animal.Sleep();
            Console.WriteLine("Animal adapted to forest");
        }
        static void Main(string[] args)
        {
            Animal animal = new Urangkottan();
            Program program = new Program();
            program.MakeForest(animal);
        }
    }
}