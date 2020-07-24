using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Commands.Place.Dto;
using ReviewManagement.App.Extension;
using System.Linq;

namespace ReviewManagement.App.Commands.Place.Create
{
    public class Validator : AbstractValidator<CommandCreatePlace>
    {
        private readonly IReviewManagementContext _context;

        public Validator(IReviewManagementContext ctx,
            IValidator<AddressDto> validatorAddress,
            IValidator<DishDto> validatorDish,
            IValidator<ImageDto> validatorImg,
            IValidator<HeaderImageDto> validatorHeaderImg)
        {
            _context = ctx;

            RuleForEach(x => x.Dishes)
                .SetValidator(validatorDish);

            RuleFor(x => x.Address)
                .SetValidator(validatorAddress);

            RuleForEach(x => x.HeaderImages)
                .SetValidator(validatorHeaderImg);

            RuleFor(x => x.Image)
                .SetValidator(validatorImg)
                .When(x => x.Image != null);

            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2);

            RuleFor(x => x.PhoneNumber)
                //.Matches(@"^[+]*[(]{0,1}[0-9]{1,4}[)]{0,1}[-\s\./0-9]*$");
                .NotEmpty();

            RuleFor(x => x.Address)
                .NotNull();
        }

        protected override bool PreValidate(ValidationContext<CommandCreatePlace> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            if (_context.Categories.AsNoTracking().FirstOrDefault(x => x.Id == command.CategoryId) == null)
            {
                result.Errors.Add(new ValidationFailure(nameof(command.CategoryId), $"The category with id: {command.CategoryId} not found."));
                return false;
            }

            return true;
        }
    }
}
