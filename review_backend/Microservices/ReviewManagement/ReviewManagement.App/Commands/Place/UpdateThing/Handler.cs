using MediatR;
using ReviewManagement.App.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Place.UpdatePlace
{
    public class Handler : IRequestHandler<Command, Domain.Entities.Place>
    {
        public IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Place> Handle(Command request, CancellationToken cancellationToken)
        {
            var place = _context.Places.FirstOrDefault(x => x.Id == request.PlaceId);
            UpdateEntity(place, request);

            var placeEntity = _context.Places.Update(place);
            await _context.SaveChangesAsync();

            return placeEntity.Entity;
        }

        private void UpdateEntity(Domain.Entities.Place place, Command command)
        {
            place.Name = command.Name ?? place.Name;
            place.CategoryId = command.CategoryId ?? place.CategoryId;
            place.ImageUrl = command.ImageUrl ?? place.ImageUrl;
        }
    }
}
