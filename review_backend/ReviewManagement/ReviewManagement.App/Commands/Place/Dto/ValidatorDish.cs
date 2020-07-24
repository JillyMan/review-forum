using FluentValidation;

namespace ReviewManagement.App.Commands.Place.Dto
{
	public class ValidatorDish : AbstractValidator<DishDto>
	{
		public ValidatorDish(IValidator<ImageDto> validatorImg)
		{
			RuleFor(x => x.Image)
				.SetValidator(validatorImg)
				.When(x => x != null);

			RuleFor(x => x.Name).NotEmpty();
		}
	}
}
