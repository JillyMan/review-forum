using AutoMapper;
using Review.App.Infrastructure;

namespace ReviewManagement.App.Commands.Place.Create
{
    public class Handler : Common.CreateHandlerBase<CommandCreatePlace, Domain.Entities.Place>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
