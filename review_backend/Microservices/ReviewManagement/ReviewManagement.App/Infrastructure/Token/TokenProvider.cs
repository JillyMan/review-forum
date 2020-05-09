using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities.Security;
using Microsoft.IdentityModel.Tokens;
using ReviewManagement.App.Infrastructure;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace ReviewManagement.App.Infrastructure.Token
{
    public class JwtTokenProvider : ITokenService
    {
        private readonly IReviewManagementContext _dbContext;

        private readonly JwtSetting _jwtSetting;
        private readonly JwtSecurityTokenHandler _tokenHandler = new JwtSecurityTokenHandler();

        public JwtTokenProvider(IReviewManagementContext context,
            JwtSetting jwtSetting)
        {
            _dbContext = context;
            _jwtSetting = jwtSetting;
        }

        public async Task<TokenInfo> CreateToken(PayloadInfo payload)
        {
            var token = TokenInfo.Create(
                GetAccessToken(payload), 
                GetRefreshToken()
            );

            //using var transaction = _dbContext.BeginTransaction();
            //var entity = _dbContext.Tokens.Add(token);

            try
            {
                //await _dbContext.SaveChangesAsync();
                //var result = entity.Entity;
                return token;
            }
            catch (Exception e)
            {
//                await transaction.CommitAsync();
                throw e;
            }
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

        private string GetAccessToken(PayloadInfo payload)
        {
            var key = Encoding.ASCII.GetBytes(_jwtSetting.Secret);

            var claims = new Claim[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, payload.FullName),
                new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.Role, payload.Role.ToString())
            };

            var token = new JwtSecurityToken(
                issuer: _jwtSetting.Issuer,
                audience: _jwtSetting.Issuer,
                claims,
                expires: DateTime.Now.AddSeconds(_jwtSetting.ExpireTimeSec),
                signingCredentials: new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature));

            var tokenString = _tokenHandler.WriteToken(token);

            return tokenString;
        }

        private string GetRefreshToken()
        {
            return string.Empty;
            //throw new NotImplementedException();
        }
    }
}
