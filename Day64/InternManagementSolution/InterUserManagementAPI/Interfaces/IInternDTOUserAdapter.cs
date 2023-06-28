using InterUserManagementAPI.Models;
using InterUserManagementAPI.Models.DTOs;

namespace InterUserManagementAPI.Interfaces
{
    public interface IInternDTOUserAdapter
    {
        public Task<User> GetUserFromInternDTOAsync(InternDTO intern);
    }
}
