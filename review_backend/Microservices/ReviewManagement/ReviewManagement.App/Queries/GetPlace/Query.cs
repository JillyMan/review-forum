using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Queries.GetPlace
{
    public class Query : IRequest<Place>
    {
        public int PlaceId { get; set; }
    }
}