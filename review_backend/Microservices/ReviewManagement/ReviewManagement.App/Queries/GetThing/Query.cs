using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Queries.GetThing
{
    public class Query : IRequest<Thing>
    {
        public int ThingId { get; set; }
    }
}