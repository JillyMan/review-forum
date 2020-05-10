using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Delete
{
	public class HandlerDeleteCity : HandlerDeleteBase<CommandDeleteEntityBase, Domain.Entities.Category>
	{
		public HandlerDeleteCity(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
