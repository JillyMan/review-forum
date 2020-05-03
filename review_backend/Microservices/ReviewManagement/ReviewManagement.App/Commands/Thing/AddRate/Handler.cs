using AutoMapper;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Thing.AddRate
{
    public class Handler : Common.CreateHandlerBase<Command, ThingRateInfo>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
