using MediatR;

namespace ReviewManagement.App.Commands.Category.Add
{
    public class Command : IRequest<Domain.Entities.Category>
    {
        public string Name { get; set; }
    }
}
