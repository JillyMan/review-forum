using MediatR;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.Country.Get
{
	public class HandlerGetCountry : IRequestHandler<QueryGetCountry, Domain.Entities.Country>
	{
		private readonly IReviewManagementContext _context;

		public HandlerGetCountry(IReviewManagementContext context)
		{
			_context = context;
		}

		public async Task<Domain.Entities.Country> Handle(QueryGetCountry request, CancellationToken cancellationToken)
		{
			var result = await _context.Countries
				.AsNoTracking()
				.Include(x => x.Cities)
				.FirstOrDefaultAsync(x => x.Id == request.Id);

			return result ?? throw new EntityNotFoundException();
		}
	}
}
