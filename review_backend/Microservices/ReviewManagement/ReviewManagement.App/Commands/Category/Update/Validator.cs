using Review.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Update
{
    public class Validator : CategoryValidatorBase<Command>
    {
        public Validator(IReviewManagementContext context)
            : base(context)
        {
        }
    }
}