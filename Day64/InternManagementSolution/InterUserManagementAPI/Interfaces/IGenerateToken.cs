using InterUserManagementAPI.Models.DTOs;

namespace InterUserManagementAPI.Interfaces
{
    public interface IGenerateToken
    {
        string GenerateToken(USerDTO user);
    }
}
