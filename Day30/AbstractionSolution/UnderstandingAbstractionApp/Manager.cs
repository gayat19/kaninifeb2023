using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingAbstractionApp
{
    internal abstract class Manager : IBanking
    {
        public void Eat()
        {
            Console.WriteLine("Though I am a bank manager I cannot eat money. I eat food only");
        }
        public void ApproveLoan()
        {
            Console.WriteLine("You loan is approved.. Be happy :-)");
        }

        public void SolveCustomerIssues()
        {
            Console.WriteLine("Problem Solved.");
        }

        public void ConductMeetings()
        {
            Console.WriteLine("Conducts meetings for employees");
        }
        public abstract void AssignWork();


    }
    class BranchManager:Manager
    {
        public override void AssignWork()
        {
            Console.WriteLine("Assigns work for every employee");
        }
    }
}
