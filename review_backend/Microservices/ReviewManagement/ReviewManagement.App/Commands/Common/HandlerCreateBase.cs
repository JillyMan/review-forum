using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Common
{
    public abstract class HandlerCreateBase<TCommand, TEntity> : IRequestHandler<TCommand, TEntity>
        where TCommand : IRequest<TEntity>
        where TEntity : BaseEntity
    {
        protected readonly IReviewManagementContext Context;
        protected readonly IMapper Mapper;

        public HandlerCreateBase(IReviewManagementContext context, IMapper mapper)
        {
            Mapper = mapper;
            Context = context;
        }

        protected abstract TEntity PrepareEntity(TCommand command);

        public async Task<TEntity> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = PrepareEntity(request);
            var entryResult = await Context.Set<TEntity>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entryResult.Entity;
        }
    }
}
