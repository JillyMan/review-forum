using System;

namespace AccessManagement.Domain.Entities
{
    public class TokenInfo : Auditable
    {
        public string Id { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public static TokenInfo Create(string access, string refresh)
        {
            return new TokenInfo()
            {
                CreatedAt = DateTimeOffset.UtcNow,
                AccessToken = access,
                RefreshToken = refresh
            };
        }
    }
}