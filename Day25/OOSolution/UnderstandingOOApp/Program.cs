namespace UnderstandingOOApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Cycle bsa, hero;
            // bsa= new Cycle(2, 0, "B.S.A");
            // hero = bsa;
            //// Cycle hero = new Cycle(2, 3, "Hero");
            // bsa.Run();
            // hero.Run();
            MotorCycle hero = new MotorCycle();
            hero.Make = "Hero Honda";
            hero.NumberOfWheels = 2;
            hero.Run();

            Console.ReadKey();
        }
    }
}