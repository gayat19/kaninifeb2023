namespace JWTAuthenticationExample.Models.DTO
{
    public class UserDTO
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string? Token { get; set; }
        public string? Role { get; set; }
    }
}
