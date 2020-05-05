using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Place.AddRate
{
    public class Command : IRequest<PlaceRate>
    {
        public int PlaceId { get; set; }

        public int UserId { get; set; }

        public float Rate { get; set; }
    }
}