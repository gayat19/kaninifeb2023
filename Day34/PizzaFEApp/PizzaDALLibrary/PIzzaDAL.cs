using PizzaModelLibrary;

namespace PizzaDALLibrary
{
    public class PIzzaDAL : IRepo<Pizza, int>
    {
        IDictionary<int,Pizza> pizzas = new Dictionary<int,Pizza>();   
        public Pizza Add(Pizza item)
        {
           pizzas.Add(item.Id,item);
            return item;
        }

        public Pizza Delete(int id)
        {
            throw new NotImplementedException();
        }

        public ICollection<Pizza> GetAll()
        {
          return pizzas.Values.ToList();
        }
    }
}