using ReviewManagement.App.Commands.Common;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Users.Update
{
	public class CommandUpdateUser : ICommandUpdateBase<UserInfo>
	{
		public int Id { get; set; }

		public bool? IsActive { get; set; }
	}
}
