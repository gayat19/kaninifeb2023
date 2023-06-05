using System.Security.Principal;

namespace InterUserManagementAPI.Models.DTOs
{
    public class USerDTO
    {
        public int UserId { get; set; }
        public string? Password { get; set; }
        public string? Role { get; set; }
        public string? Token { get; set; }
    }
}
