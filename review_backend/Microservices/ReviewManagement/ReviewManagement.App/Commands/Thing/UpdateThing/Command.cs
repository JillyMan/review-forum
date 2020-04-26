using MediatR;

namespace ReviewManagement.App.Commands.Thing.UpdateThing
{
    public class Command : IRequest<Domain.Entities.Thing>
    {
        public int ThingId { get; set; }

        public string UrlImage { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }
    }
}
