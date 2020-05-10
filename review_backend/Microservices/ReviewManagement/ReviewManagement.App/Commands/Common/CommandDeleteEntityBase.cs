using MediatR;

namespace ReviewManagement.App.Commands.Common
{
	public class CommandDeleteEntityBase : IRequest
	{
		public int Id { get; set; }
	}
}
