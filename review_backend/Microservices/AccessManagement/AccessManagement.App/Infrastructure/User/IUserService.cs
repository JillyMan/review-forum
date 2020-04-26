using AccessManagement.App.Models;
using AccessManagement.Domain.Entities;
using System.Threading.Tasks;

namespace AccessManagement.App.Services.User
{
    public interface IUserService
    {
        Task<UserInfo> GetById(string id);

        Task<UserInfo> Authenticate(AuthenticateInfo authorizeInfo);

        Task<UserInfo> Register(RegisterInfo registerInfo);
    }
}
