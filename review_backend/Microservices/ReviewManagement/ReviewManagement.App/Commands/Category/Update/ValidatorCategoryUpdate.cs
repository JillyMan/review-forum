using FluentValidation;

namespace ReviewManagement.App.Commands.Category.Update
{
	public class ValidatorUpdateCategory : AbstractValidator<CommandCategoryUpdate>
	{
		public ValidatorUpdateCategory()
		{
			RuleFor(x => x.Name)
				.NotEmpty();
		}
	}
}