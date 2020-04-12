using System.Threading.Tasks;

namespace DiplomReview.Core.Authorization.RemoteServices.AccessManagementService
{
    public interface IAccessManagementClient
    {
        Task<UserInfo> GetUserAsync(string id);
    }
}
