namespace ReviewManagement.Domain.Entities.Security
{
	public class UserSettingInfo
    {
        public int Id { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

        public string Login { get; set; }
    }
}