namespace ReviewManagement.Domain.Entities.Security
{
    public class TokenInfo
    {
        public int Id { get; set; }

        public string AccessToken { get; set; }

        public string RefreshToken { get; set; }

        public static TokenInfo Create(string access, string refresh)
        {
            return new TokenInfo()
            {
                AccessToken = access,
                RefreshToken = refresh
            };
        }
    }
}