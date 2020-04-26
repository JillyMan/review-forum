using MediatR;
using Review.App.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Thing.AddThing
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
            var thing = Domain.Entities.Thing.Create(request.UrlImage, request.CategoryId, request.Description);
            var thingEntity = await _context.Things.AddAsync(thing);
            await _context.SaveChangesAsync();
            return thingEntity.Entity;
        }
    }
}
