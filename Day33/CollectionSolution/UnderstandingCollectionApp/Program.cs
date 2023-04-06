using System.Collections;

namespace UnderstandingCollectionApp
{
    internal partial class Program
    {
        void UnderstandingCollection()
        {
            ArrayList numbers =new ArrayList();
            numbers.Add(100);//boxing
            numbers.Add(1234.5);
            numbers.Add("334.5");
            numbers.Add("Five");
            double sum = 0;
            foreach (object i in numbers) 
            { 
                double num = double.Parse(i.ToString());//Unboxing
                sum += num;
            }
        }
        void UndertandingGenericList()
        {
            List<double> numbers = new List<double>();
            numbers.Add(100);
            numbers.Add(1234.5);
            numbers.Add(334.5f);//implicit type casting
            //numbers.Add("Five");//not allowed
            //double sum = 0;
            //foreach (var i in numbers)
            //{
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            Console.WriteLine("The number of elements curently in the list "+numbers.Count);
            Console.WriteLine("Does thelist contain 100?? "+numbers.Contains(100));
            numbers.Remove(1234.5);
            Console.WriteLine("After removal");
            Console.WriteLine("The number of elements curently in the list " + numbers.Count);
            numbers.Add(988);
            Console.WriteLine("The capacity of the list is "+numbers.Capacity);
            numbers.Add(200);
            numbers.Add(300);
            numbers.Add(1800);
            
            Console.WriteLine("The capacity of the list is " + numbers.Capacity);
        }
        void UnderstaindingSet()
        {
            HashSet<string> names = new HashSet<string>()
            {
                "Ramu","Somu","Bimu","Lomu","Komu","Somu"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

        }
        void UnderstaindingSet2()
        {
            SortedSet<string> names = new SortedSet<string>()
            {
                "Ramu","Somu","Bimu","Lomu","Komu","Somu"
            };
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }
        void UnderstandingCustomList()
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee());
            employees[0].Id = 1;
            employees[0].Name = "Test";
            employees[0].Salary = 12342432;
            employees.Add(new Employee(2, "Tina", 235465));
            employees.Add(new Employee { Id = 3, Name = "Anita", Salary = 543534 });
            employees.Sort(new SortEmployeeByName());
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            Employee e = new Employee(2, "Tina", 235465);
            Console.WriteLine("Is employee with Id 102 there? "+employees.Contains(e));
        }
        void UnderstandingSortedCustomTypes()
        {
            SortedSet<Employee> employees = new SortedSet<Employee>();
            Employee e = new Employee();
            e.Id = 1;
            e.Name = "Test";
            e.Salary = 12342432;
            employees.Add(e);
            employees.Add(new Employee(2, "Tina", 235465));
            employees.Add(new Employee { Id = 3, Name = "Anita", Salary = 543534 });
            foreach (var item in employees)
            {
                Console.WriteLine(item);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //new Program().Check();
            //new Program().UnderstandingCollection();
            //new Program().UndertandingGenericList();
            //new Program().UnderstaindingSet2();
            new Program().UnderstandingCustomList();
            //new Program().UnderstandingSortedCustomTypes();
        }
    }
}