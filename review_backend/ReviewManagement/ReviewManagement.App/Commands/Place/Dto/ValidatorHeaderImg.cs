using FluentValidation;
using ReviewManagement.App.Extension;

namespace ReviewManagement.App.Commands.Place.Dto
{
	public class ValidatorImg : AbstractValidator<ImageDto>
	{
		public ValidatorImg()
		{
			RuleFor(x => x.ImageUrl)
				.ValidateUrl()
				.When(x => x.ImageUrl != null);
		}
	}

	public class ValidatorHeaderImg : AbstractValidator<HeaderImageDto>
	{
		public ValidatorHeaderImg()
		{
			RuleFor(x => x.Image)
				.NotNull()
				.When(x => x.Image != null);
		}
	}
}
