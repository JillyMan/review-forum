using AutoMapper;
using MediatR;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Common
{
    public abstract class CreateHandlerBase<TCommand, TResult> : IRequestHandler<TCommand, TResult>
        where TCommand : IRequest<TResult>
        where TResult : BaseEntity
    {
        protected readonly IReviewManagementContext Context;
        protected readonly IMapper Mapper;

        public CreateHandlerBase(IReviewManagementContext context, IMapper mapper)
        {
            Mapper = mapper;
            Context = context;
        }

        public async Task<TResult> Handle(TCommand request, CancellationToken cancellationToken)
        {
            var entity = Mapper.Map<TResult>(request);
            entity.CreatedAt = DateTime.UtcNow;

            var entryResult = await Context.Set<TResult>().AddAsync(entity);
            await Context.SaveChangesAsync();
            return entryResult.Entity;
        }
    }
}
