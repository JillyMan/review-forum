using MediatR;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.GetPlace
{
    public class Handler : IRequestHandler<Query, Place>
    {
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<Place> Handle(Query request, CancellationToken cancellationToken)
        {
            var place = await _context.Places
                .AsNoTracking()
                .Include(x => x.Comments)
                .FirstOrDefaultAsync(x => x.Id == request.PlaceId);

            return place ?? throw new EntityNotFoundException();
        }
    }
}
