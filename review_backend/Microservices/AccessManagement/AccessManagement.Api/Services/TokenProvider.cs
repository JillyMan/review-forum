using Microsoft.IdentityModel.Tokens;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace AccessManagement.Api.Services
{
    public class TokenProvider
    {
        private readonly string Secret;
        private readonly int ExpireTimeSec;

        public TokenProvider(string secret, int expireTimeSec)
        {
            Secret = secret;
            ExpireTimeSec = expireTimeSec;
        }

        public (string access, string refresh) GetToken(PayloadInfo payload)
        {
            var key = Encoding.ASCII.GetBytes(Secret);
            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, payload.FullName),
                        new Claim(ClaimTypes.NameIdentifier, payload.Id),
                        new Claim(ClaimTypes.Role, payload.Role)
                    }),
                Expires = DateTime.UtcNow.AddSeconds(ExpireTimeSec),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            var tokenString = tokenHandler.WriteToken(token);

            return (tokenString, "");
        }
    }
}
