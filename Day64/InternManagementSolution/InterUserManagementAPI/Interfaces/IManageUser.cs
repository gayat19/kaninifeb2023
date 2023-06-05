using InterUserManagementAPI.Models.DTOs;

namespace InterUserManagementAPI.Interfaces
{
    public interface IManageUser
    {
        public Task<UserDTO> Login(UserDTO user);
        public Task<UserDTO> Register(InternDTO intern);
        public Task<UserDTO> ChangeStatus(UserDTO user);
    }
}
