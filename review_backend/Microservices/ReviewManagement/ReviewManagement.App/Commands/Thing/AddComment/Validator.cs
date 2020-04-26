using FluentValidation;
using FluentValidation.Results;
using Review.App.Infrastructure;
using ReviewManagement.App.Resources;
using System.Linq;

namespace ReviewManagement.App.Commands.Thing.AddComment
{
    public class Validator : AbstractValidator<Command>
    {
        private IReviewManagementContext _context;

        public Validator(IReviewManagementContext context)
        {
            _context = context;

            RuleFor(x => x.Text)
                .NotEmpty();
            // todo: check if user exists.
        }

        protected override bool PreValidate(ValidationContext<Command> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            var thing = _context.Things.FirstOrDefault(x => x.Id == command.ThingId);
            if (thing == null)
            {
                result.Errors.Add(new ValidationFailure(nameof(command.ThingId), string.Format(ValidationErrorMessages.CantAddCommentToThingIdNotFound, command.ThingId)));
                return false;
            }

            //todo: add user check.

            return true;
        }

    }
}
