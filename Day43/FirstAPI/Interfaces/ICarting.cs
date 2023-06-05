using FirstAPI.Models.DTO;

namespace FirstAPI.Interfaces
{
    public interface ICarting
    {
        public Task<ICollection<CartProduct>> GetAll();
    }
}
