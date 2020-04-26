using FluentValidation;
using FluentValidation.Results;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using System;
using System.Linq;

namespace ReviewManagement.App.Commands.Thing.UpdateThing
{
    public class Validator : AbstractValidator<Command>
    {
        private IReviewManagementContext _context;

        public Validator(IReviewManagementContext ctx)
        {
            _context = ctx;
        }

        public Validator()
        {
            RuleFor(x => x.UrlImage)
                .Custom((url, ctx) =>
                {
                    if (!Uri.IsWellFormedUriString(url, UriKind.Absolute))
                    {
                        ctx.AddFailure("Invalid img url.");
                    }
                });

            RuleFor(x => x.Description)
                .NotEmpty();
        }

        protected override bool PreValidate(ValidationContext<Command> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            if (_context.Things.FirstOrDefault(x => x.Id == command.ThingId) == null)
            {
                throw new EntityNotFoundException();
            }

            if (_context.Categories.FirstOrDefault(x => x.Id == command.CategoryId) == null)
            {
                result.Errors.Add(new ValidationFailure(nameof(command.CategoryId), $"The category with id: {command.CategoryId} not found."));
                return false;
            }

            return true;
        }
    }
}