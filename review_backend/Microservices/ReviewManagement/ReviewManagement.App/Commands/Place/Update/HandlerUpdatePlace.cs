using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Place.Update
{
    public class HandlerUpdatePlace : IRequestHandler<CommandUpdatePlace, Domain.Entities.Place>
    {
        private IMapper _mapper;
        private IReviewManagementContext _context;

        public HandlerUpdatePlace(IReviewManagementContext context, IMapper mapper)
        {
            _context = context;
        }

        public async Task<Domain.Entities.Place> Handle(CommandUpdatePlace request, CancellationToken cancellationToken)
        {
            var mappedEntity = _mapper.Map<Domain.Entities.Place>(request.Id);
            
            var place = _context.Places.FirstOrDefault(x => x.Id == request.Id);
            _context.Places.Remove(place);
            var updatedEntry = _context.Places.Update(mappedEntity);
            await _context.SaveChangesAsync();
            return updatedEntry.Entity;
        }
    }
}
