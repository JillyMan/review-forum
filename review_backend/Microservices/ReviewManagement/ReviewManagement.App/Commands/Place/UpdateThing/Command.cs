using MediatR;

namespace ReviewManagement.App.Commands.Place.UpdatePlace
{
    public class Command : IRequest<Domain.Entities.Place>
    {
        public int PlaceId { get; set; }

        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int? CategoryId { get; set; }

        public string Description { get; set; }
    }
}
