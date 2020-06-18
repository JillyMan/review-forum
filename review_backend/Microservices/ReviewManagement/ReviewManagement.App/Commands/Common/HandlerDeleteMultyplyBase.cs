using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Common
{
	public class HandlerDeleteMultyplyBase<TCommand, TEntity> : IRequestHandler<TCommand>
		where TCommand : CommandDeleteMultiplyBase
		where TEntity : BaseEntity, new()
	{
		private readonly IMapper _mapper;
		private readonly IReviewManagementContext _context;

		public HandlerDeleteMultyplyBase(IReviewManagementContext context, IMapper mapper)
		{
			_mapper = mapper;
			_context = context;
		}

		public async Task<Unit> Handle(TCommand request, CancellationToken cancellationToken)
		{
			var cityIds = request.Ids.Select(x => new TEntity() { Id = x });

			_context.Set<TEntity>().RemoveRange(cityIds);
			var deleted = await _context.SaveChangesAsync();
#if DEBUG
			if (deleted != request.Ids.Count)
			{
				throw new ApplicationException("delete != request.Ids.Count");
			}
#endif
			return Unit.Value;
		}
	}
}
