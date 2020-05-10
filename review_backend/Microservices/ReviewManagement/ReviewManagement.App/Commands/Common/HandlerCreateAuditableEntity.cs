using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System;

namespace ReviewManagement.App.Commands.Common
{
	public class HandlerCreateAuditableEntity<TCommand, TResult> : HandlerCreateBase<TCommand, TResult>
		where TCommand : IRequest<TResult>
		where TResult : AuditableEntity
	{
		public HandlerCreateAuditableEntity(IReviewManagementContext context, IMapper mapper) 
			: base(context, mapper)
		{
		}

		protected override TResult PrepareEntity(TCommand command)
		{
			var entity = Mapper.Map<TResult>(command);
			entity.CreatedAt = DateTime.UtcNow;
			return entity;
		}
	}
}
