using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Thing.AddRate
{
    public class Command : IRequest<ThingRateInfo>
    {
        public int ThingId { get; set; }

        public string UserId { get; set; }

        public float Rate { get; set; }
    }
}