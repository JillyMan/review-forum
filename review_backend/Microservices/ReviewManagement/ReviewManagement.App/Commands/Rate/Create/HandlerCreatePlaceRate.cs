using AutoMapper;
using Review.App.Infrastructure;
using ReviewManagement.App.Commands.Rate.Base;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class HandlerCreatePlaceRate : HandlerCreateRateBase<CommandCreatePlaceRate, PlaceRate>
	{
		public HandlerCreatePlaceRate(IReviewManagementContext context, IMapper mapper) 
			: base(context, mapper)
		{
		}
	}

	public class HandlerCreateDishRate : HandlerCreateRateBase<CommandCreateDishRate, DishRate>
	{
		public HandlerCreateDishRate(IReviewManagementContext context, IMapper mapper)
			: base(context, mapper)
		{
		}
	}
}
