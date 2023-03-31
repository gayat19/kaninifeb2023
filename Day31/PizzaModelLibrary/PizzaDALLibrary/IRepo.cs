using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALLibrary
{
    public interface IRepo
    {
        Pizza Get(int id);
        Pizza Add(Pizza pizza,out bool status);
        Pizza[] GetAll();
        Pizza Update(Pizza pizza,out bool status);
        Pizza Delete(int id, out bool status);
    }
}
