using Review.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Add
{
	public class Validator : CategoryValidatorBase<Command>
	{
		private IReviewManagementContext _context;

		public Validator(IReviewManagementContext context)
			: base(context)
		{
		}
	}
}
