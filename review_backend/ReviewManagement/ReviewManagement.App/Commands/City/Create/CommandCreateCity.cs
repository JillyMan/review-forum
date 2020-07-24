using MediatR;

namespace ReviewManagement.App.Commands.City.Create
{
	public class CommandCreateCity : IRequest<Domain.Entities.City>
	{
		public int CountryId { get; set; }

		public string Name { get; set; }
	}
}
