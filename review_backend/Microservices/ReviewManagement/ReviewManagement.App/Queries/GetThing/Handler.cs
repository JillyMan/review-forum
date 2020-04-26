using MediatR;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.GetThing
{
    public class Handler : IRequestHandler<Query, Thing>
    {
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<Thing> Handle(Query request, CancellationToken cancellationToken)
        {
            var thing = await _context.Things
                .AsNoTracking()
                .Include(x => x.Comments)
                // TODO: it's realy shit, but i can't fix it fast now
                .Include(x => x.Rates)
                .FirstOrDefaultAsync(x => x.Id == request.ThingId);

            if (thing == null)
            {
                throw new System.Exception($"The thing with id: {request.ThingId} not found");
            }

            return thing;
        }
    }
}
