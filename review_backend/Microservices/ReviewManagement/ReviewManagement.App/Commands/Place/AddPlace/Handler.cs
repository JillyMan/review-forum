using AutoMapper;
using Review.App.Infrastructure;

namespace ReviewManagement.App.Commands.Place.AddPlace
{
    public class Handler : Common.CreateHandlerBase<Command, Domain.Entities.Place>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
