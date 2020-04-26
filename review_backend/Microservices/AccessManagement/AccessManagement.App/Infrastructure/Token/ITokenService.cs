using AccessManagement.App.Models;
using AccessManagement.Domain.Entities;
using System.Threading.Tasks;

namespace AccessManagement.App.Infrastructure.Token
{
    public interface ITokenService
    {
        Task<TokenInfo> CreateToken(PayloadInfo payload);

        Task<TokenInfo> RefreshToken(TokenInfo token);
    }
}
