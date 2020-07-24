using ReviewManagement.Domain.Enums;
using ReviewManagement.Domain.Entities.Security;
using System;

namespace ReviewManagement.Domain.Entities
{
    public class UserInfo : BaseEntity
    {
        public bool IsActive { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Role Role { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public DateTime CreatedAt { get; set; }

        public DateTime? UpdatedAt { get; set; }

        public UserSettingInfo UserSettingInfo { get; set; }

        public static UserInfo Create(
            string firstName,
            string lastName,
            Role role,
            UserSettingInfo userSetting)
        {
            return new UserInfo
            {
                IsActive = true,
                Role = role,
                FirstName = firstName,
                LastName = lastName,
                UserSettingInfo = userSetting,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}