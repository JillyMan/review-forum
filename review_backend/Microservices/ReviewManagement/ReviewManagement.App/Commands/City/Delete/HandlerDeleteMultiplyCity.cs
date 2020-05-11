using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.City.Delete
{
	public class HandlerDeleteMultiplyCity : HandlerDeleteMultyplyBase<CommandDeleteMultiplyCity, Domain.Entities.City>
	{
		public HandlerDeleteMultiplyCity(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
