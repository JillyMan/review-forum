using AutoMapper;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using ReviewManagement.App.Commands.Common;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class HandlerCreatePlaceRate : HandlerCreateAuditableEntity<CommandCreatePlaceRate, PlaceRate>
	{
		public HandlerCreatePlaceRate(IReviewManagementContext context, IMapper mapper) 
			: base(context, mapper)
		{
		}
	}
}
