using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Common
{
	public abstract class HandlerCreateBaseEntity<TCommand, TResult> : HandlerCreateBase<TCommand, TResult>
		where TCommand : IRequest<TResult>
		where TResult : BaseEntity
	{
		public HandlerCreateBaseEntity(IReviewManagementContext context, IMapper mapper) 
			: base(context, mapper)
		{
		}

		protected override TResult PrepareEntity(TCommand command)
		{
			return Mapper.Map<TResult>(command);
		}
	}
}
