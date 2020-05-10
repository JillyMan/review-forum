using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Country.Create
{
    public class HandlerCreateCountry : HandlerCreateBase<CommandCreateCountry, Domain.Entities.Country>
    {
        public HandlerCreateCountry(IReviewManagementContext ctx, IMapper mapper) :
            base(ctx, mapper)
        {
        }
    }
}
