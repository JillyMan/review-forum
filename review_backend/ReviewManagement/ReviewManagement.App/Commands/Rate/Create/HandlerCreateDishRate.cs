using AutoMapper;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using ReviewManagement.App.Commands.Common;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class HandlerCreateDishRate : HandlerCreateAuditableEntity<CommandCreateDishRate, DishRate>
	{
		public HandlerCreateDishRate(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
