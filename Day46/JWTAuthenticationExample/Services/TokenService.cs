using JWTAuthenticationExample.Interfaces;
using JWTAuthenticationExample.Models.DTO;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JWTAuthenticationExample.Services
{
    public class TokenService : ITokenGenerate
    {
        private readonly SymmetricSecurityKey _key;

        public TokenService(IConfiguration configuration) 
        {
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["TokenKey"]));
        }
        public string GenerateToken(UserDTO user)
        {
            string token =string.Empty;
            //User identity
            var claims = new List<Claim>
            {
                new Claim(JwtRegisteredClaimNames.NameId,user.Username)
            };
            //Signature algorithm
            var cred = new SigningCredentials(_key,SecurityAlgorithms.HmacSha256);
            //Assembling the token details
            var tokenDescription = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(3),
                SigningCredentials = cred
            };
            //Using teh handler to generate the token
            var tokenHandler = new JwtSecurityTokenHandler();
            var myToken = tokenHandler.CreateToken(tokenDescription);
            token = tokenHandler.WriteToken(myToken);
            return token;
        }
    }
}
