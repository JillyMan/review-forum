using MediatR;
using Review.App.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Thing.UpdateThing
{
    public class Handler : IRequestHandler<Command, Domain.Entities.Thing>
    {
        public IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Thing> Handle(Command request, CancellationToken cancellationToken)
        {
            var thing = _context.Things.FirstOrDefault(x => x.Id == request.ThingId);
            UpdateEntity(thing, request);

            var thingEntity = _context.Things.Update(thing);
            await _context.SaveChangesAsync();

            return thingEntity.Entity;
        }

        private void UpdateEntity(Domain.Entities.Thing thing, Command command)
        {
            thing.Name = command.Name ?? thing.Name;
            thing.CategoryId = command.CategoryId ?? thing.CategoryId;
            thing.UrlIImage = command.UrlImage ?? thing.UrlIImage;
            thing.Description = command.Description ?? thing.Description;
        }
    }
}
