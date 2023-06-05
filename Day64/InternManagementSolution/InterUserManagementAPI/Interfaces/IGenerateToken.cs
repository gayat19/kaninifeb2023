using InterUserManagementAPI.Models.DTOs;

namespace InterUserManagementAPI.Interfaces
{
    public interface IGenerateToken
    {
        public string GenerateToken(UserDTO user);
    }
}
