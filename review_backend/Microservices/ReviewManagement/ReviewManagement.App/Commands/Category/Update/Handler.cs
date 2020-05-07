using AutoMapper;
using MediatR;
using ReviewManagement.App.Infrastructure;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Category.Update
{
	public class Handler : IRequestHandler<Command, Domain.Entities.Category>
	{
		protected IMapper Mapper;
		protected IReviewManagementContext Context;

		public Handler(IReviewManagementContext context, IMapper mapper)
		{
			Mapper = mapper;
			Context = context;
		}

		public async Task<Domain.Entities.Category> Handle(Command request, CancellationToken cancellationToken)
		{
			var updateEntity = Context.Categories.First(x => x.Id == request.Id);
			updateEntity.Name = request.Name;
			await Context.SaveChangesAsync();
			return updateEntity;
		}
	}
}
