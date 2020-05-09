using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Place.Create
{
    public class Handler : HandlerCreateAuditableEntity<CommandCreatePlace, Domain.Entities.Place>
    {
        public Handler(IReviewManagementContext context, IMapper mapper)
            : base(context, mapper)
        {
        }
    }
}
