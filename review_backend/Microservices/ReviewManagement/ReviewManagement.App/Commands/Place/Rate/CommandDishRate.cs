using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Place.Rate
{
	public class CommandDishRate : CommandRateBase<DishRate>
	{
		public int DishId { get; set; }
	}
}
