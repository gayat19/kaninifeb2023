using ConsumeService.Models;

namespace ConsumeService.Interfaces
{
    public interface IUser
    {
        public Task<User> Login(User user);
       
    }
}
