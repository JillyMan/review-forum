using MediatR;

namespace ReviewManagement.App.Commands.Common
{
	public interface ICommandUpdateBase<TResponse> : IRequest<TResponse>
	{
		public int Id { get; set; }
	}
}
