using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.City.Delete
{
	public class HandlerDeleteCity : HandlerDeleteBase<CommandDeleteEntityBase, Domain.Entities.City>
	{
		public HandlerDeleteCity(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
