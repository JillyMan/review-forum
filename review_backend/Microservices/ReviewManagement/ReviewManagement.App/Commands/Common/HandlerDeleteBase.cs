using AutoMapper;
using MediatR;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Common
{
	public class HandlerDeleteBase<TCommand, TEntity> : IRequestHandler<TCommand>
		where TCommand : CommandDeleteEntityBase
		where TEntity : BaseEntity
	{
		protected IMapper Mapper;
		protected IReviewManagementContext Context;

		public HandlerDeleteBase(IReviewManagementContext context, IMapper mapper)
		{
			Mapper = mapper;
			Context = context;
		}

		public async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
		{
			var entity = Context.Set<TEntity>().FirstOrDefault(x => x.Id == request.Id);
			if (entity == null)
			{
				throw new EntityNotFoundException();
			}

			Context.Set<TEntity>().Remove(entity);
			await Context.SaveChangesAsync();

			return Unit.Value;
		}
	}
}
