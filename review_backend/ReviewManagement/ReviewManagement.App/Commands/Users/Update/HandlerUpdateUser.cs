using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Users.Update
{
	public class HandlerUpdateUser : HandlerUpdateEntity<CommandUpdateUser, UserInfo>
	{
		public HandlerUpdateUser(IReviewManagementContext context, IMapper mapper) 
			: base(context, mapper)
		{
		}

		protected override UserInfo UpdateEntity(UserInfo oldEntity, CommandUpdateUser command)
		{
			if (command.IsActive.HasValue && 
				oldEntity.IsActive != command.IsActive &&
				oldEntity.Role != Domain.Enums.Role.Admin)
			{
				oldEntity.IsActive = command.IsActive.Value;
			}

			return oldEntity;
		}
	}
}
