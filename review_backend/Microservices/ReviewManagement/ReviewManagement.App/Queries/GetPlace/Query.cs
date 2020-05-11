using MediatR;
using ReviewManagement.App.Models.Place;

namespace ReviewManagement.App.Queries.GetPlace
{
    public class Query : IRequest<PlaceModel>
    {
        public int PlaceId { get; set; }
    }
}