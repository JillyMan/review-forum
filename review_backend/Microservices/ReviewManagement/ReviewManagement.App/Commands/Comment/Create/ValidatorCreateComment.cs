using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using System.Linq;

namespace ReviewManagement.App.Commands.Place.AddComment
{
    public class Validator : AbstractValidator<CommandCreateComment>
    {
        private IReviewManagementContext _context;

        public Validator(IReviewManagementContext context)
        {
            _context = context;

            RuleFor(x => x.Text)
                .MinimumLength(15)
                .NotEmpty();
        }

        protected override bool PreValidate(ValidationContext<CommandCreateComment> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            var place = _context.Places.AsNoTracking().FirstOrDefault(x => x.Id == command.PlaceId);
            if (place == null)
            {
                throw new EntityNotFoundException();
            }

            //todo: add user check.

            return true;
        }

    }
}