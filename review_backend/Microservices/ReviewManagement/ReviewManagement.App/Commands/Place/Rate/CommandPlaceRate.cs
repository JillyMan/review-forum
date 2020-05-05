using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Place.Rate
{
	public class CommandPlaceRate : CommandRateBase<DishRate>
	{
		public int PlaceId { get; set; }
	}
}
