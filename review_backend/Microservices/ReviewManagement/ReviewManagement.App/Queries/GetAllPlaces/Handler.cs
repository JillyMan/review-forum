using MediatR;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.GetAllPlaces
{
    public class Handler : IRequestHandler<Query, IEnumerable<Place>>
    {
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Place>> Handle(Query request, CancellationToken cancellationToken)
        {
            return await _context.Places
                .AsNoTracking()
                .Include(x => x.Address)
                .ToListAsync();
        }
    }
}
