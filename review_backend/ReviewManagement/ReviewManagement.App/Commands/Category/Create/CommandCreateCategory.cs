using MediatR;

namespace ReviewManagement.App.Commands.Category.Create
{
    public class CommandCreateCategory : IRequest<Domain.Entities.Category>
	{
		public string Name { get; set; }
	}
}
