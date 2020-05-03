using AutoMapper;
using Review.App.Infrastructure;

namespace ReviewManagement.App.Commands.Thing.AddThing
{
    public class Handler : Common.CreateHandlerBase<Command, Domain.Entities.Thing>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
