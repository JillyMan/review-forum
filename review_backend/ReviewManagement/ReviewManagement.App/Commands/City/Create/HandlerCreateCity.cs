using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.City.Create
{
    public class HandlerCreateCity : HandlerCreateBase<CommandCreateCity, Domain.Entities.City>
    {
        public HandlerCreateCity(IReviewManagementContext ctx, IMapper mapper) :
            base(ctx, mapper)
        {
        }
    }
}
