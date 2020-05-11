using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Commands.Place.Dto;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using System.Linq;

namespace ReviewManagement.App.Commands.Place.Update
{
    public class ValidatorUpdatePlace : AbstractValidator<CommandUpdatePlace>
    {
        private IReviewManagementContext _context;

        public ValidatorUpdatePlace(IReviewManagementContext ctx, IValidator<ImageDto> validatorImg)
        {
            _context = ctx;

            RuleFor(x => x.Image)
                .SetValidator(validatorImg)
                .When(x => x != null);

            RuleFor(x => x.Name)
                .MinimumLength(2)
                .Custom((d, ctx) =>
                {
                    if (d != null && d.Length == 0)
                    {
                        ctx.AddFailure("'Name' can't be empty");
                    }
                });
        }

        protected override bool PreValidate(ValidationContext<CommandUpdatePlace> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            if (_context.Places.AsNoTracking().FirstOrDefault(x => x.Id == command.Id) == null)
            {
                throw new EntityNotFoundException();
            }

            if (command.CategoryId.HasValue &&
                _context.Categories
                    .AsNoTracking()
                    .FirstOrDefault(x => x.Id == command.CategoryId) == null)
            {
                result.Errors.Add(new ValidationFailure(nameof(command.CategoryId), $"The category with id: {command.CategoryId} not found."));
                return false;
            }

            return true;
        }
    }
}