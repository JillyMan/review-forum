using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Queries.Country.GetAll
{
    public class HandlerGetAllCountry : Base.HandlerGetAllBase<QueryGetAllCountry, Domain.Entities.Country>
    {
        public HandlerGetAllCountry(IReviewManagementContext context)
            : base(context)
        {
        }
    }
}
