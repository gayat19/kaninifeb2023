using PizzaModelLibrary;

namespace UnderstandingAbstractionApp
{
    internal class Program
    {
        static void CustomerBanking(ICustomerManager manager)
        {
            manager.ApproveLoan();
            manager.SolveCustomerIssues();
         
        }
        static void EmployeeWork(IEmployeeManager manager)
        {
            manager.ConductMeetings();
            manager.AssignWork();
        }
        static void BankingActivity(IBanking banking)
        {
            banking.SolveCustomerIssues();
            banking.AssignWork();
            banking.ApproveLoan();
            banking.ConductMeetings();
        }
        static void Main(string[] args)
        {
            //Pizza pizza = new Pizza(233.4f,"ABC",101);
            //Console.WriteLine(pizza);
            Manager manager = new BranchManager();
            CustomerBanking(manager);
            EmployeeWork(manager);
            Console.WriteLine("Hello, World!");
        }
    }
}