using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Comment.Create
{
    public class HandlerCreateComment : HandlerCreateAuditableEntity<CommandCreateComment, Domain.Entities.Comment>
    {
        public HandlerCreateComment(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
