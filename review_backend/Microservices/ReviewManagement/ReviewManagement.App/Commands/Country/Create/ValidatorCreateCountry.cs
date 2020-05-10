using FluentValidation;

namespace ReviewManagement.App.Commands.Country.Create
{
	public class ValidatorCreateCity : AbstractValidator<CommandCreateCountry>
	{
		public ValidatorCreateCity()
		{
			RuleFor(x => x.Name)
				.NotEmpty();
		}
	}
}
