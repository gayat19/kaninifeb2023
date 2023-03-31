using PizzaModelLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaDALLibrary
{
    public class PizzaRepository : IRepo
    {
        static Pizza[] pizzas;
        static int currentLength;
        static PizzaRepository()
        {
            currentLength = 0;
        }
        public PizzaRepository()
        {
            int count = 0;
            Console.WriteLine("Please enter the count of types of pizzas");
            while (!int.TryParse(Console.ReadLine(), out count))
                Console.WriteLine("Invalid number of pizza. Please try agian");
            pizzas = new Pizza[count];
        }
        public Pizza Add(Pizza pizza, out bool status)
        {
           status = false;
            if(currentLength<pizzas.Length)
            {
                // pizzas[currentLength++] = pizza;
                pizzas[currentLength] = pizza;
                currentLength++;
                status = true;
                return pizza;
            }
            bool _isEmptyPostion = false;
            int _position = -1;
            for (int i = 0; i < pizzas.Length; i++)
            {
                if (pizzas[i]== null)
                {
                    _isEmptyPostion=true;
                    _position = i;
                    break;
                }
            }
            if(_isEmptyPostion)
            {
                pizzas[_position] = pizza;
                status = true;
                return pizza;
            }
            return null;
        }
        int GetPizzaIndex(int id)
        {
            int idx = -1;
            for (int i = 0; i < pizzas.Length; i++)
            {
                if (pizzas[i] != null)
                {
                    if (pizzas[i].Id == id)
                    {
                        idx = i;
                        break;
                    }
                }
            }
            return idx;
        }
        public Pizza Delete(int id, out bool status)
        {
            int _position = GetPizzaIndex(id);
            if (_position >= 0)
            {
                Pizza pizza = pizzas[_position];
                pizzas[_position] = null;
                status = true;
                return pizza;
            }
            status = false;
            return null;
        }

        public Pizza Get(int id)
        {
            Pizza pizza = null;
            int _position = GetPizzaIndex(id);
            if (_position >= 0)
                pizza = pizzas[_position];
            return pizza;
        }

        public Pizza[] GetAll()
        {
            if(pizzas.Length>0)
                return pizzas;
            return null;
        }

        public Pizza Update(Pizza pizza, out bool status)
        {
            int _position = GetPizzaIndex(pizza.Id);
            if (_position >= 0)
            {
                pizzas[_position] = pizza;
                status = true;
                return pizza;
            }
            status = false;
            return null;
        }
    }
}
