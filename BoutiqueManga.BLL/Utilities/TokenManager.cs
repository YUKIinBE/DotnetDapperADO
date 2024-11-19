using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;

namespace BoutiqueManga.BLL.Utilities
{
    public class TokenManager(IConfiguration configuration)
    {
        public string CreateToken(int id, string email, bool isSeller)
        {
            var credentials = new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8
                .GetBytes(configuration["Jwt:Key"] ?? throw new Exception("Missing JWT config"))),
                SecurityAlgorithms.HmacSha256
                );
            JwtSecurityTokenHandler handler = new JwtSecurityTokenHandler();
            var token = handler.CreateJwtSecurityToken(
                null,
                null,
                new ClaimsIdentity([
                    new Claim(ClaimTypes.NameIdentifier, id.ToString()),
                    new Claim(ClaimTypes.Email, email),
                    //TODO isSeller => enum Role
                    new Claim(ClaimTypes.Role, isSeller? "Seller" : "Customer")]),
                DateTime.Now,
                DateTime.Now.AddDays(1),
                DateTime.Now,
                credentials
                );
            return handler.WriteToken(token);
        }
    }
}
