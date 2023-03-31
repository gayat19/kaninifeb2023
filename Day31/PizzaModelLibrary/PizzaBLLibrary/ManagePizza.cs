using PizzaDALLibrary;
using PizzaModelLibrary;
using System.Diagnostics.SymbolStore;

namespace PizzaBLLibrary
{
    public class ManagePizza:IShopping
    {
        static Pizza[] cart;
        static int cartCount =0;
        IRepo _repo;
        public ManagePizza()
        {
            cart = new Pizza[5];
        }
        public ManagePizza(IRepo repo):this()
        {
            _repo = repo;
        }

        public bool AddToCart(Pizza pizza)
        {
            bool result = false;
            int _position = -1;
           if(cartCount<cart.Length)
            {
                if(CheckPizzaPresent(pizza.Id,out _position))
                {
                    ((StorePizza)cart[_position]).Quantity += 1;//Type casting
                }
                else
                {
                    cart[cartCount] = pizza;
                    cartCount++;
                }
                    
                result = true;
            }
            return result;
        }

        private bool CheckPizzaPresent(int id,out int idx)
        {
            bool status = false;
            for (int i = 0; i < cart.Length; i++)
            {
                if (cart[i] != null)
                {
                    if (cart[i].Id == id)
                    {
                        status = true;
                        idx = i;
                        return true;
                    }
                }
            }
            idx = -1;
            return status;
        }

        public Pizza[] Checkout()
        {
            Pizza[] myCart = cart;
            for (int i = 0; i < cart.Length; i++)
            {
                if (cart[i] != null)
                {
                    if (!CheckQuantity(cart[i].Id, ((StorePizza)cart[i]).Quantity))
                        return null;
                }
            }
            for (int i = 0; i < cart.Length; i++)
            {
                if (cart[i] != null)
                {
                    ReduceQuantity(cart[i].Id, ((StorePizza)cart[i]).Quantity);
                }
            }
            cart = new Pizza[5];
            return myCart;
        }

        private void ReduceQuantity(int id, int quantity)
        {
            Pizza thePizza = _repo.Get(id);
            ((StorePizza)thePizza).Quantity -= quantity;
        }
        private bool CheckQuantity(int id,int qty)
        {
            Pizza thePizza = _repo.Get(id);                                                                                                                                        
            if(thePizza==null)
            {
                return false;
            }
            if(((StorePizza)thePizza).Quantity-qty<0)
            {
                return false;
            }
            return true;

        }

        public Pizza[] GetPizzas()
        {
            return _repo.GetAll();
        }
    }
}