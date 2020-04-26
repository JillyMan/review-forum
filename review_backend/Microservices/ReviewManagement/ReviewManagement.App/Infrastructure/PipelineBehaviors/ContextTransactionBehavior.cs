using MediatR;
using Review.App.Infrastructure;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Infrastructure.PipelineBehaviors
{
    public class ContextTransactionBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
        where TRequest : IRequest<TResponse>
    {
        private readonly IReviewManagementContext _context;

        public ContextTransactionBehavior(IReviewManagementContext ctx)
        {
            _context = ctx;
        }

        public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
        {
            using (var transaction = _context.BeginTransaction())
            {
                var result = await next();

                await _context.SaveChangesAsync();

                await transaction.CommitAsync();

                return result;
            }
        }
    }
}
