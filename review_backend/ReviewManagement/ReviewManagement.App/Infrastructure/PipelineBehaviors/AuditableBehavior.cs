using MediatR;
using ReviewManagement.App.Models;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Infrastructure.PipelineBehaviors
{
	public class AuditableBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse>
		where TRequest : IRequest<TResponse>
	{
		private readonly ICurrentUserContext _userContext;

		public AuditableBehavior(ICurrentUserContext userContext)
		{
			_userContext = userContext;
		}

		public async Task<TResponse> Handle(TRequest request, CancellationToken cancellationToken, RequestHandlerDelegate<TResponse> next)
		{
			if (request is ICreateCommand createCommand)
			{
				createCommand.CreatedBy = _userContext.CurrentUser;
			}

			return await next();
		}
	}
}
