using PizzaModelLibrary;
using PizzaDALLibrary;

namespace PizzaBLLibrary
{
    public class PizzaManage
    {
        private readonly IRepo<Pizza, int> _repo;

        public PizzaManage()
        {
            
        }
        public PizzaManage(IRepo<Pizza,int> repo)
        {
            _repo = repo;
        }
        public Pizza Add(Pizza pizza)
        {
            return _repo.Add(pizza);
        }
        public ICollection<Pizza> GetAll()
        {
            return _repo.GetAll();
        }
    }
}