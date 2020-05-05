using AutoMapper;
using MediatR;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Place.Rate
{
	public class HandlerRateBase<TCommand, TResponse> : IRequestHandler<TCommand, TResponse>
		where TCommand : CommandRateBase<TResponse>
		where TResponse : RatableEntity
	{
		protected IReviewManagementContext Context { get; set; }
		protected IMapper Mapper { get; set; }


		public HandlerRateBase(IReviewManagementContext context, IMapper mapper)
		{
			Context = context;
			Mapper = mapper;
		}

		public Task<TResponse> Handle(TCommand request, CancellationToken cancellationToken)
		{
			throw new NotImplementedException();
		}
	}
}
