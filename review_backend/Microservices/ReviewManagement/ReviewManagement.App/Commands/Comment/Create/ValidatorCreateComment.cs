using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using System.Linq;

namespace ReviewManagement.App.Commands.Comment.Create
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

            if (_context.Places
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == command.PlaceId) == null)
            {
                throw new EntityNotFoundException();
            }

            return true;
        }

    }
}