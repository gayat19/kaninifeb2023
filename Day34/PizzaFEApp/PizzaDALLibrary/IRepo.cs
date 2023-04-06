using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALLibrary
{
    public interface IRepo<T,K>
    {
        T Add(T item);
        ICollection<T> GetAll();
        T Delete(K id);

    }
}
