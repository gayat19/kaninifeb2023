using PizzaBLLibrary;
using PizzaDALLibrary;
using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFEApp
{
    internal class PizzaProvider
    {
        PizzaManage manage;
        IRepo<Pizza, int> pizzaRepo;
        public PizzaProvider()
        {
            //pizzaRepo = new PIzzaDAL();
            pizzaRepo = new PizzaADORepo();
            manage = new PizzaManage(pizzaRepo);
        }
        public void AddPizza()
        {
            Pizza pizza = new Pizza() { Id = 101, Name = "OPP", Price = 111 };
            try
            {
                manage.Add(pizza);
            }
            catch (ArgumentNullException ane)
            {
                Console.WriteLine(ane.Message);
            }
            catch (ArgumentException ae)
            {
                Console.WriteLine(ae.Message);
            }
            

        }
        public void PiringAllPizza()
        {
            var pizzas = manage.GetAll().ToList();
            if(pizzas.Count > 0)
            {
                foreach (var item in pizzas)
                {
                    Console.WriteLine(item);
                }
            }
            else
                Console.WriteLine("No pizzas in store right now. All sold out");
        }
    }
}
