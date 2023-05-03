using JWTAuthenticationExample.Interfaces;
using JWTAuthenticationExample.Models;
using System.Diagnostics;

namespace JWTAuthenticationExample.Services
{
    public class UserRepo : IBaseRepo<string, User>
    {
        private readonly JWTContext _context;

        public UserRepo(JWTContext context)
        {
            _context = context;
        }
        public User Add(User item)
        {
            try
            {
                _context.Users.Add(item);
                _context.SaveChanges();
                return item;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
                Debug.WriteLine(item);
            }
            return null;
        }

        public User Get(string key)
        {
            var user = _context.Users.FirstOrDefault(u=>u.Username == key);
            return user;
        }

        
    }
}
