using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Thing.AddComment
{
    public class Command : IRequest<Comment>
    {
        public int ThingId { get; set; }

        public string UserId { get; set; }

        public string Text { get; set; }
    }
}
