using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using System;
using System.Linq;

namespace ReviewManagement.App.Commands.Thing.AddThing
{
    public class Validator : AbstractValidator<Command>
    {
        private IReviewManagementContext _context;

        public Validator(IReviewManagementContext ctx)
        {
            _context = ctx;

            RuleFor(x => x.UrlImage)
                .Custom((url, ctx) =>
                {
                    if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                        ctx.AddFailure("Invalid img url.");
                    }
                })
                .NotEmpty()
                .When(x => x != null);

            RuleFor(x => x.Name)
                .NotEmpty()
                .MinimumLength(2);

            RuleFor(x => x.Description)
                .NotEmpty();
        }

        protected override bool PreValidate(ValidationContext<Command> context, ValidationResult result)
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
