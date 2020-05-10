using FluentValidation;

namespace ReviewManagement.App.Commands.Category.Create
{
	public class ValidatorCreateCountry : AbstractValidator<CommandCreateCategory>
	{
		public ValidatorCreateCountry()
		{
			RuleFor(x => x.Name)
				.NotEmpty();
		}
	}
}
