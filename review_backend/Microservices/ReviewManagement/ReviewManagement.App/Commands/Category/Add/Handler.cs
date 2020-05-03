using AutoMapper;
using Review.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Add
{
    public class Handler : Common.CreateHandlerBase<Command, Domain.Entities.Category>
    {
        public Handler(IReviewManagementContext ctx, IMapper mapper) :
            base(ctx, mapper)
        {
        }
    }
}
