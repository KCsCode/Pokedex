using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;

namespace PokedexAPI.Utility
{
    public class JwtManager
    {
        private const string SECRET = "this_is_a_secret_123";
        private const string ISSUER = "test";
        private const string AUDIENCE = "test";

        public string Secret
        {
            get { return SECRET; }
        }
        public string Issuser
        {
            get { return ISSUER; }
        }
        public string Audience
        {
            get { return AUDIENCE; }
        }

        public string GenerateJSONToken(string username, int timeOutInMinutes = 15)
        {
            SymmetricSecurityKey securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(SECRET));
            SigningCredentials credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
            Claim[] claims = new[]{
                  new Claim(JwtRegisteredClaimNames.Sub, username),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
            };

            var token = new JwtSecurityToken(
                issuer: ISSUER,
                audience: AUDIENCE,
                claims,
                expires: DateTime.Now.AddMinutes(timeOutInMinutes),
                signingCredentials: credentials);

            var encodedToken = new JwtSecurityTokenHandler().WriteToken(token);
            return encodedToken;
        }
}
}
