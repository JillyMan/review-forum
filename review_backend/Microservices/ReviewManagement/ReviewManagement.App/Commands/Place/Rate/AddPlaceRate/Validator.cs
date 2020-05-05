using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using System.Linq;

namespace ReviewManagement.App.Commands.Place.AddRate
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

            var rateInfo = _context.PlaceRateInfos
                .AsNoTracking()
                .FirstOrDefault(x => x.PlaceId == command.PlaceId && x.UserId == command.UserId);

            if (rateInfo != null)
            {
                throw new EntityAlreadyExistsException();
            }

            throw new UserNotFoundException();
            // TODO: if user does not exists throw exception.

            return true;
        }
    }
}
