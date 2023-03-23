namespace UnderstandingArrayApp
{
    internal class Program
    {
        void BasicArray()
        {
            //int[] numbers = { 19, 67, 100, 20, 45 };
            //int[] numbers = new int[5]{ 19, 67, 100, 20, 45 };
            int[] numbers = new int[5];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Please enter {i+1} number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Array.Sort(numbers);
            Console.WriteLine("After sort");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        void UnderstandingStringArray()
        {
            string name = "Something that i would like to play with";
            //char[] seperate = name.ToCharArray();
            //seperate[4] = 'z';
            //name = new string(seperate);
            //Console.WriteLine(name);
            string[] words = name.Split(' ');
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
        }
        void UnderstandingTwoDimArray()
        {
            double[,] numbers = new double[3, 5];
            //Console.WriteLine(numbers.Length);
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                Console.WriteLine($"Please enter the scores of class {i+1}");
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine($"Please enter teh score of student {j+1} of class {i+1}");
                    numbers[i,j] = Convert.ToDouble(Console.ReadLine());
                }
            }
        }
        void UnderstandingJaggedArray()
        {
            string[][] skills = new string[3][];
            for (int i = 0; i < skills.GetLength(0); i++)
            {
                Console.WriteLine("Please enter the number of skills you have");
                int count = Convert.ToInt32(Console.ReadLine());
                skills[i] = new string[count];
                for (int j = 0; j < skills[i].Length; j++)
                {
                    skills[i][j] = Console.ReadLine();
                }
            }
            for (int i = 0; i < skills.GetLength(0); i++)
            {
                Console.WriteLine($"Skills of USer{i+1}");
                
                for (int j = 0; j < skills[i].Length; j++)
                {
                    Console.Write("\t"+skills[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //program.BasicArray();
            //new Program().BasicArray();//anon object
            //new Program().UnderstandingStringArray();
            //new Program().UnderstandingTwoDimArray();
            new Program().UnderstandingJaggedArray();
        }
    }
}