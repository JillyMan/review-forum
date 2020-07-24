using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Queries.Base;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Queries.GetAllCategory
{
    public class HandlerGetAllCountry : HandlerGetAllBase<QueryGetAllCountry, Category>
    {
        public HandlerGetAllCountry(IReviewManagementContext context)
            : base(context)
        {
        }
    }
}
