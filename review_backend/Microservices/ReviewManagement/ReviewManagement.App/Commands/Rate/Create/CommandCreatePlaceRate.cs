using ReviewManagement.App.Commands.Rate.Base;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class CommandCreatePlaceRate : CommandCreateRateBase<PlaceRate>
	{
		public int PlaceId { get; set; }
	}
}
