using MediatR;
using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Comment.Create
{
    public class CommandCreateComment : IRequest<Domain.Entities.Comment>, ICreateCommand
    {
        public int PlaceId { get; set; }

        public string Text { get; set; }

        public UserInfo CreatedBy { get; set; }
    }
}
