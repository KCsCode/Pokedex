using Microsoft.IdentityModel.Tokens;
using PokedexAPI.Model;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PokedexAPI.Controllers
{
    public class JwtManager
    {
        private const string SECRET = "this_is_a_secret_123";
        public static string GenerateJSONToken(string username, int timeOutInMinutes = 15)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            Claim[] claims = new[]{
                  new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: "test",
                audience: "test",
                claims,
                expires: DateTime.Now.AddMinutes(timeOutInMinutes),
                signingCredentials: credentials);

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }
}
}
