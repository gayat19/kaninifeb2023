using ConsumeService.Models;

namespace ConsumeService.Interfaces
{
    public interface IManageProduct
    {
        Task<ICollection<Product>> GetAll();
        void SetToken(string token);
    }
}
