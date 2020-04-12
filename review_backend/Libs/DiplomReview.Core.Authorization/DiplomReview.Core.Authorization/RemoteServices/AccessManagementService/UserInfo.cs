using System.Runtime.Serialization;

namespace DiplomReview.Core.Authorization.RemoteServices.AccessManagementService
{
    [DataContract]
    public class UserInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "first_name")]
        public string FirstName { get; set; }

        [DataMember(Name = "last_name")]
        public string LastName { get; set; }

        [DataMember(Name = "role")]
        public string Role { get; set; }
       
        [DataMember(Name = "is_active")]
        public bool IsActive { get; set; }
    }
}