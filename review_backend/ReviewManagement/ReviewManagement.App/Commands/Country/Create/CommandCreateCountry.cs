using MediatR;

namespace ReviewManagement.App.Commands.Country.Create
{
	public class CommandCreateCountry : IRequest<Domain.Entities.Country>
	{
		public string Name { get; set; }
	}
}
