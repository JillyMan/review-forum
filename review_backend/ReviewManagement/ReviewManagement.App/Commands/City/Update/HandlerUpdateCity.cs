using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.City.Update
{
	public class HandlerUpdateCity : HandlerUpdateEntity<CommandUpdateCity, Domain.Entities.City>
	{
		public HandlerUpdateCity(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}

		protected override Domain.Entities.City UpdateEntity(Domain.Entities.City oldEntity, CommandUpdateCity command)
		{
			oldEntity.CountryId = command.CountryId ?? oldEntity.CountryId;
			oldEntity.Name = !string.IsNullOrEmpty(command.Name) ? command.Name : oldEntity.Name;
			return oldEntity;
		}
	}
}
