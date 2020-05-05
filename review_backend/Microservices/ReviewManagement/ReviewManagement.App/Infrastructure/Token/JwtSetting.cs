namespace ReviewManagement.App.Infrastructure.Token
{
    public class JwtSetting
    {
        public string Secret { get; }

        public int ExpireTimeSec { get; }

        public string Issuer { get; set; }

        public JwtSetting(string secret, int expireTimeSec, string issuer)
        {
            Secret = secret;
            ExpireTimeSec = expireTimeSec;
            Issuer = issuer;
        }
    }
}
