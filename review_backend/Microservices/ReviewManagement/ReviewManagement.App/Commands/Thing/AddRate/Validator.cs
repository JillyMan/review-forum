using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using System.Linq;

namespace ReviewManagement.App.Commands.Thing.AddRate
{
    public class Validator : AbstractValidator<Command>
    {
        public IReviewManagementContext _context;
        public Validator(IReviewManagementContext ctx)
        {
            _context = ctx;

            RuleFor(x => x.Rate)
                .Must(x => x >= 0 && x <= 5);
        }

        protected override bool PreValidate(ValidationContext<Command> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            var rateInfo = _context.ThingRateInfos
                .AsNoTracking()
                .FirstOrDefault(x => x.ThingId == command.ThingId && x.UserId == command.UserId);

            if (rateInfo != null)
            {
                throw new EntityAlreadyExistsException();
            }

            // TODO: if user does not exists throw exception.

            return true;
        }
    }
}
