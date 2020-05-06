using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using ReviewManagement.Domain.Entities;
using System.Linq;

namespace ReviewManagement.App.Commands.Rate.Base
{
    public class ValidatorCreateRateBase<TCommand, TCommandResult> : AbstractValidator<TCommand>
        where TCommand : CommandCreateRateBase<TCommandResult>
        where TCommandResult : RatableEntity
    {
        protected IReviewManagementContext _context;

        public ValidatorCreateRateBase(IReviewManagementContext ctx)
        {
            _context = ctx;

            RuleFor(x => x.Rate)
                .Must(x => x >= 0 && x <= 5);
        }

        protected override bool PreValidate(ValidationContext<TCommand> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            if (_context.Users.AsNoTracking().FirstOrDefault(x => x.Id == command.UserId) == null)
            {
                throw new UserNotFoundException();
            }

            return true;
        }
    }
}
