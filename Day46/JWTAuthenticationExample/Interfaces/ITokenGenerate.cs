using JWTAuthenticationExample.Models.DTO;

namespace JWTAuthenticationExample.Interfaces
{
    public interface ITokenGenerate
    {
        public string GenerateToken(UserDTO user);
    }
}
