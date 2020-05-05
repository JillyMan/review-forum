using ReviewManagement.Domain.Enums;
using ReviewManagement.Domain.Entities.Security;

namespace ReviewManagement.Domain.Entities
{
    public class UserInfo : AuditableEntity
    {
        public bool IsActive { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public UserSettingInfo UserSettingInfo { get; set; }

        public static UserInfo Create(
            string firstName,
            string lastName,
            Role role,
            UserSettingInfo userSetting)
        {
            return new UserInfo
            {
                Role = role,
                FirstName = firstName,
                LastName = lastName,
                UserSettingInfo = userSetting
            };
        }
    }
}