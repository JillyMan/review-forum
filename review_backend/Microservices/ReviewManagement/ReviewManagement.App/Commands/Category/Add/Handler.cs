using MediatR;
using Review.App.Infrastructure;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Category.Add
{
    public class Handler : IRequestHandler<Command, Domain.Entities.Category>
    {
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext ctx)
        {
            _context = ctx;
        }

        public Task<Domain.Entities.Category> Handle(Command request, CancellationToken cancellationToken)
        {

            throw new NotImplementedException();
        }
    }
}
