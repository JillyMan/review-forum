namespace ReviewManagement.Domain.Enums
{
	public enum Role
	{
		User,
		SuperUser,
		Admin,
	}

	public class RoleNames 
	{
		public const string User = "User";
		public const string SuperUser = "SuperUser";
		public const string Admin = "Admin";
		private static readonly string[] Roles = new string[3] { User, SuperUser, Admin };

		public static string GetName(int i)
		{
			return i < 3 && i >= 0 ? Roles[i] : "undefined";
		}
	}
}
