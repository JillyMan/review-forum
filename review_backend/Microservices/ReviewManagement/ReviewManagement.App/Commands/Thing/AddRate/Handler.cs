using MediatR;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Thing.AddRate
{
    public class Handler : IRequestHandler<Command, ThingRateInfo>
    {
        public IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<ThingRateInfo> Handle(Command request, CancellationToken cancellationToken)
        {
            var rateInfo = ThingRateInfo.Create(request.ThingId, request.UserId, request.Rate);

            var entityRateInfo = await _context.ThingRateInfos.AddAsync(rateInfo);

            await _context.SaveChangesAsync();

            return entityRateInfo.Entity;
        }
    }
}
