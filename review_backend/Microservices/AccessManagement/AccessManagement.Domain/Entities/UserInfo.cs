using System;
using System.Collections.Generic;

namespace AccessManagement.Domain.Entities
{
    public class UserInfo : Auditable
    {
        public string Id { get; set; }

        public bool IsActive { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public string Login { get; set; }

        public string Role { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public static UserInfo Create(
            string id, 
            string firstName, 
            string lastName, 
            string login, 
            byte[] hash, 
            byte[] salt,
            bool isActive = false)
        {
            return new UserInfo
            {
                Id = id,
                FirstName = firstName,
                LastName = lastName,
                Login = login,
                IsActive = isActive,
                PasswordHash = hash,
                PasswordSalt = salt,
                CreatedAt = DateTimeOffset.UtcNow,
            };
        }
    }
}