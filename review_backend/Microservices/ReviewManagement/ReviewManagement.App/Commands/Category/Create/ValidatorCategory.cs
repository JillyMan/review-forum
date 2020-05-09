using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Add
{
	public class ValidatorCategory : CategoryValidatorBase<CommandCreateaCategory>
	{
		private IReviewManagementContext _context;

		public ValidatorCategory(IReviewManagementContext context)
			: base(context)
		{
		}
	}
}
