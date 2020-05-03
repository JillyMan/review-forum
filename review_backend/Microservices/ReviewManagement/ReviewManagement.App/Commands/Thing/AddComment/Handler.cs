using AutoMapper;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Thing.AddComment
{
    public class Handler : Common.CreateHandlerBase<Command, Comment>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
