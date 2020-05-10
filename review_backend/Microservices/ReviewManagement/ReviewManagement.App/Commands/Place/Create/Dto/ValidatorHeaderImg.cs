using FluentValidation;
using ReviewManagement.App.Extension;

namespace ReviewManagement.App.Commands.Place.Create.Dto
{
	public class ValidatorHeaderImg : AbstractValidator<HeaderImageDto>
	{
		public ValidatorHeaderImg()
		{
			RuleFor(x => x.ImageUrl)
				.ValidateUrl()
				.When(x => x != null);
		}
	}
}
