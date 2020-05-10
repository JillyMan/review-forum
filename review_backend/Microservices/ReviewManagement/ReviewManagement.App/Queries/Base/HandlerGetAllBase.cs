using MediatR;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.Base
{
    public class HandlerGetAllBase<TQuery, TEntity> : IRequestHandler<TQuery, IEnumerable<TEntity>>
        where TQuery : IRequest<IEnumerable<TEntity>>
        where TEntity : BaseEntity
    {
        private readonly IReviewManagementContext _context;

        public HandlerGetAllBase(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<TEntity>> Handle(TQuery request, CancellationToken cancellationToken)
        {
            return await _context.Set<TEntity>()
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
