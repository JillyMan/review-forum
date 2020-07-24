using ReviewManagement.App.Commands.Rate.Base;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class CommandCreateDishRate : CommandCreateRateBase<DishRate>
	{
		public int PlaceId { get; set; }

		public int DishId { get; set; }
	}
}
