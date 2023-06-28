using InterUserManagementAPI.Interfaces;
using InterUserManagementAPI.Models;
using InterUserManagementAPI.Models.DTOs;
using System.Security.Cryptography;
using System.Text;

namespace InterUserManagementAPI.Services
{
    public class ManageUserService : IManageUser
    {
        private readonly IRepo<int, User> _userRepo;
        private readonly IRepo<int, Intern> _internRepo;
        private readonly IGeneratePassword _passwordService;
        private readonly IGenerateToken _tokenService;
        private readonly IInternDTOUserAdapter _userAdapter;

        public ManageUserService(IRepo<int,User> userRepo,
            IRepo<int,Intern> internRepo,
            IGeneratePassword passwordService,
            IGenerateToken tokenService,
            IInternDTOUserAdapter userAdapter) 
        { 
            _userRepo = userRepo;
            _internRepo = internRepo;
            _passwordService = passwordService;
            _tokenService = tokenService;
           _userAdapter = userAdapter;
        }
        public Task<UserDTO> ChangeStatus(UserDTO user)
        {
            throw new NotImplementedException();
        }

        public async Task<UserDTO> Login(UserDTO user)
        {
            var userData = await _userRepo.Get(user.UserId);
            if (userData != null)
            {
                var hmac = new HMACSHA512(userData.PasswordKey);
                var userPass = hmac.ComputeHash(Encoding.UTF8.GetBytes(user.Password));
                for (int i = 0; i < userPass.Length; i++)
                {
                    if (userPass[i] != userData.PasswordHash[i])
                        return null;
                }
                user = new UserDTO();
                user.UserId = userData.UserId;
                user.Role = userData.Role;
                user.Token = _tokenService.GenerateToken(user);
            }
            return user;

        }

        public async Task<UserDTO> Register(InternDTO intern)
        {

            UserDTO user = null;
            var userNew = await _userAdapter.GetUserFromInternDTOAsync(intern);
            var userResult = await _userRepo.Add(userNew); 
            var internResult = await _internRepo.Add(intern);
            if ( userResult != null && internResult != null)
            {
                user = new UserDTO();
                user.UserId = internResult.Id;
                user.Role = userResult.Role;
                user.Token = _tokenService.GenerateToken(user);
            }
            return user;

        }
    }
}
