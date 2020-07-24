using FluentValidation;

namespace ReviewManagement.App.Commands.Country.Update
{
	public class ValidatorCountryUpdate : AbstractValidator<CommandCountryUpdate>
	{
		public ValidatorCountryUpdate()
		{
			RuleFor(x => x.Name)
				.NotEmpty()
				.When(x => x.Name != null);
		}
	}
}