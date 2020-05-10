using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Common
{
	public abstract class HandlerUpdateEntity<TCommand, TEntity> : IRequestHandler<TCommand, TEntity>
		where TCommand : ICommandUpdateBase<TEntity>
		where TEntity : BaseEntity
	{
		protected IMapper Mapper { get; }

		protected IReviewManagementContext Context { get; }

		public HandlerUpdateEntity(IReviewManagementContext context, IMapper mapper)
		{
			Mapper = mapper;
			Context = context;
		}

		protected virtual TEntity UpdateEntity(TEntity oldEntity, TCommand command)
		{
			return Mapper.Map<TEntity>(command);
		}

		public async Task<TEntity> Handle(TCommand request, CancellationToken cancellationToken)
		{
			var entityToUpdate = Context.Set<TEntity>().FirstOrDefault(x => x.Id == request.Id);
			if (entityToUpdate == null)
			{
				throw new EnityNotFountException();
			}
			var updatedEntity = UpdateEntity(entityToUpdate, request);
			await Context.SaveChangesAsync();
			return updatedEntity;
		}
	}
}
