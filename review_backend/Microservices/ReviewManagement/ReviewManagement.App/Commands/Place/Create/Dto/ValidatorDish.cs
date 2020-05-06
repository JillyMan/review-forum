using FluentValidation;
using ReviewManagement.App.Extension;

namespace ReviewManagement.App.Commands.Place.Create.Dto
{
	public class ValidatorDish : AbstractValidator<DishDto>
	{
		public ValidatorDish()
		{
			RuleFor(x => x.ImageUrl)
				.ValidateUrl()
				.When(x => x != null);

			RuleFor(x => x.Name).NotEmpty();
		}
	}
}
