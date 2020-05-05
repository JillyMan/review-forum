using AutoMapper;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Place.AddRate
{
    public class Handler : Common.CreateHandlerBase<Command, PlaceRate>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
