using MediatR;

namespace ReviewManagement.App.Queries.Country.Get
{
	public class QueryGetCountry : IRequest<Domain.Entities.Country>
	{
		public int Id { get; set; }
	}
}
