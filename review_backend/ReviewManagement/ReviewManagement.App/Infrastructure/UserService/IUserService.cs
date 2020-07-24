using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities;
using System.Threading.Tasks;

namespace ReviewManagement.App.Services.User
{
    public interface IUserService
    {
        Task<UserInfo> GetById(int id);

        Task<UserInfo> Authenticate(AuthenticateInfo authorizeInfo);

        Task<UserInfo> Register(RegisterInfo registerInfo);
    }
}
