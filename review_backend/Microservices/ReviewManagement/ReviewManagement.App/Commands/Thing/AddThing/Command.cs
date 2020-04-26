using MediatR;

namespace ReviewManagement.App.Commands.Thing.AddThing
{
    public class Command : IRequest<Domain.Entities.Thing>
    {
        public string UrlImage { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }
    }
}
