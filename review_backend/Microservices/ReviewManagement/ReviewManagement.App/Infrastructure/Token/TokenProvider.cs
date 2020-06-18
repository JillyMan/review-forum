using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities.Security;
using Microsoft.IdentityModel.Tokens;
using ReviewManagement.App.Infrastructure;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Infrastructure.Token
{
    public class JwtTokenProvider : ITokenService
    {
        private readonly IReviewManagementContext _dbContext;
        private readonly Random _random = new Random();
        private readonly JwtSetting _jwtSetting;
        private readonly JwtSecurityTokenHandler _tokenHandler = new JwtSecurityTokenHandler();

        public JwtTokenProvider(IReviewManagementContext context,
            JwtSetting jwtSetting)
        {
            _dbContext = context;
            _jwtSetting = jwtSetting;
        }

        public Task<TokenInfo> CreateToken(UserInfo payload)
        {
            var token = TokenInfo.Create(
                GetAccessToken(payload),
                GetRefreshToken()
            );

            return Task.FromResult(token);
        }

        public Task<TokenInfo> RefreshToken(TokenInfo token)
        {
            throw new NotImplementedException();
        }

        private JwtSecurityToken ParseAccessToken(string tokenString)
        {
            var token = _tokenHandler.ReadJwtToken(tokenString);
            return token;
        }

        private string GetAccessToken(UserInfo payload)
        {
            var key = Encoding.UTF8.GetBytes(_jwtSetting.Secret);
            var credantials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature);

            var claims = new Claim[]
            {
                new Claim(ClaimTypes.NameIdentifier, payload.Id.ToString()),
                new Claim(ClaimTypes.Name, payload.Id.ToString()),
                new Claim(ClaimTypes.Role, payload.Role.ToString()),
            };

            var token = new JwtSecurityToken(
                issuer: _jwtSetting.Issuer,
                audience: _jwtSetting.Issuer,
                claims,
                expires: DateTime.Now.AddSeconds(_jwtSetting.ExpireTimeSec),
                signingCredentials: credantials);

            var tokenString = _tokenHandler.WriteToken(token);

            return tokenString;
        }

        private string GetRefreshToken(string access_token)
        {
            return GetRandomStringBySize(10) + access_token.PadRight(6);
        }

        private string GetRandomStringBySize(int size)
        {
            var result = "";
            for(int i = 0; i < size; ++i)
            {
                result += (char)_random.Next();
            }
            return result;
        }
    }
}
