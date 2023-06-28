using InterUserManagementAPI.Interfaces;
using InterUserManagementAPI.Models;
using InterUserManagementAPI.Models.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace InterUserManagementAPI.Services
{
    public class InternDTOUserAdapter : IInternDTOUserAdapter
    {
        private readonly IGeneratePassword _passwordService;

        public InternDTOUserAdapter(IGeneratePassword passwordService)
        { 
            _passwordService = passwordService;

        }
        public async Task<User> GetUserFromInternDTOAsync(InternDTO intern)
        {
            var hmac = new HMACSHA512();
            string? generatedPassword = await _passwordService.GeneratePassword(intern);
            intern.User.PasswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(generatedPassword ?? "1234"));
            intern.User.PasswordKey = hmac.Key;
            intern.User.Role = "Intern";
            return intern.User;
        }
    }
}
