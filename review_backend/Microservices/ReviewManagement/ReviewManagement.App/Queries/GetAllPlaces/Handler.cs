using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Queries.GetAllPlaces
{
    public class Handler : Base.HandlerGetAllBase<Query, Place>
    {
        public Handler(IReviewManagementContext context)
            : base(context)
        {
        }
    }
}
