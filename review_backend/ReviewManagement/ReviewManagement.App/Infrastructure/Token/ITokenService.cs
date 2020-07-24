using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Entities.Security;
using System.Threading.Tasks;

namespace ReviewManagement.App.Infrastructure.Token
{
    public interface ITokenService
    {
        Task<TokenInfo> CreateToken(UserInfo payload);

        Task<TokenInfo> RefreshToken(TokenInfo token);
    }
}
