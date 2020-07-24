using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Delete
{
	public class HandlerDeleteCountry : HandlerDeleteBase<CommandDeleteEntityBase, Domain.Entities.Country>
	{
		public HandlerDeleteCountry(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
