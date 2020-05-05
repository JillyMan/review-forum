using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Place.AddComment
{
    public class Command : IRequest<Comment>
    {
        public int PlaceId { get; set; }

        public int UserId { get; set; }

        public string Text { get; set; }
    }
}
