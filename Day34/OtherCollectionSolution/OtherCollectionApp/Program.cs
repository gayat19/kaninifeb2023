namespace OtherCollectionApp
{
    internal class Program
    {
       
        //static void UnderstandingStack()
        //{
        //    Stack<int> stack = new Stack<int>();
        //    stack.Push(1);
        //    stack.Push(110);
        //    stack.Push(231);
        //    int count = stack.Count;
        //    //foreach (int i in stack)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(stack.Peek());
        //    }
        //    Console.WriteLine("The length of the stack now is "+stack.Count);
        //}
        //static void UnderstandingQueue()
        //{
        //    Queue<int> queue = new Queue<int>();
        //    queue.Enqueue(1);
        //    queue.Enqueue(110);
        //    queue.Enqueue(231);
        //    int count = queue.Count;
        //    //foreach (int i in stack)
        //    //{
        //    //    Console.WriteLine(i);
        //    //}
        //    for (int i = 0; i < count; i++)
        //    {
        //        Console.WriteLine(queue.Dequeue());
        //    }
        //    Console.WriteLine("The length of the stack now is " + queue.Count);
        //}
        void Add(int n1,int n2)
        {
            int sum = 0;
            sum = n1 + n2;
            Console.WriteLine($"The sum of {n1} and {n2} is {sum}");
        }
        void Product(int n1, int n2)
        {
            int sum = 0;
            sum = n1 * n2;
            Console.WriteLine($"The product of {n1} and {n2} is {sum}");
        }
        public delegate void MyDelegateType(int num1, int num2);//Creating the delegate type
        MyDelegateType myDelegateRef;//Creating the ref to teh delegate
        void Calculate(MyDelegateType delegate1)//taking a method as parameter
        {
            Console.WriteLine("Please enter teh first number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter teh second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            delegate1(num1,num2);//delegate ref to invoke the method
        }
     
        void AssignMethod()
        {
            myDelegateRef = new MyDelegateType(Add);
            myDelegateRef += Product;
            myDelegateRef += delegate (int n1, int n2)
            {
                int result = 0;
                result = n1 - n2;
                Console.WriteLine($"The result of subtracting {n2} from {n1} is {result}");
            };
            //myDelegateRef += ( n1,n2)=>
            //{
            //    int result = 0;
            //    result = n1 / n2;
            //    Console.WriteLine($"The result of dividing {n1} by {n2} is {result}");
            //};
            myDelegateRef += (n1, n2) =>Console.WriteLine($"The result of dividing {n1} by {n2} is {n1 / n2}");
            Calculate(myDelegateRef);
        }
        static void Main(string[] args)
        {
            //UnderstandingQueue();
            new Program().AssignMethod();
        }
    }
}