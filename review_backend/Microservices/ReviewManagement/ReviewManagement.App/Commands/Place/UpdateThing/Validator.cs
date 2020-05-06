using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Extension;
using System;
using System.Linq;

namespace ReviewManagement.App.Commands.Place.UpdatePlace
{
    public class Validator : AbstractValidator<Command>
    {
        private IReviewManagementContext _context;

        public Validator(IReviewManagementContext ctx)
        {
            _context = ctx;

            RuleFor(x => x.ImageUrl)
                .Cascade(CascadeMode.StopOnFirstFailure)
                .ValidateUrl();

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

        protected override bool PreValidate(ValidationContext<Command> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            if (_context.Places.AsNoTracking().FirstOrDefault(x => x.Id == command.PlaceId) == null)
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