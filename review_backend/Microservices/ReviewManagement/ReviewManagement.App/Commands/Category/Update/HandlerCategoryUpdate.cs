using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Update
{
	public class HandlerCategoryUpdate : HandlerUpdateEntity<CommandCategoryUpdate, Domain.Entities.Category>
	{
		public HandlerCategoryUpdate(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
