using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Country.Update
{
	public class HandlerCountryUpdate : HandlerUpdateEntity<CommandCountryUpdate, Domain.Entities.Country>
	{
		public HandlerCountryUpdate(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}

		protected override Domain.Entities.Country UpdateEntity(Domain.Entities.Country oldEntity, CommandCountryUpdate command)
		{
			var newEnitity = Mapper.Map<Domain.Entities.Country>(command);

			oldEntity.Cities = newEnitity.Cities ?? oldEntity.Cities;
			oldEntity.Name = !string.IsNullOrEmpty(command.Name) ? command.Name : oldEntity.Name;

			return oldEntity;
		}
	}
}
