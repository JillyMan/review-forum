using AutoMapper;
using MediatR;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Rate.Base
{
	public class HandlerCreateRateBase<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
		where TCommand : CommandCreateRateBase<TResponse>
		where TResponse : RatableEntity
	{
		protected IMapper Mapper { get; set; }

		protected IReviewManagementContext Context { get; set; }

		public HandlerCreateRateBase(IReviewManagementContext context, IMapper mapper)
		{
			Context = context;
			Mapper = mapper;
		}

		public async Task<TResponse> Handle(TCommand request, CancellationToken cancellationToken)
		{
			var rate = Mapper.Map<TResponse>(request);
			var entryRate = await Context.Set<TResponse>().AddAsync(rate);
			await Context.SaveChangesAsync();
			return entryRate.Entity;
		}
	}
}
