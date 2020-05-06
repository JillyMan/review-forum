using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Commands.Rate.Base;
using ReviewManagement.App.Exceptions;
using ReviewManagement.Domain.Entities;
using System.Linq;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class ValidatorCreatePlaceRate : ValidatorCreateRateBase<CommandCreatePlaceRate, PlaceRate>
    {
        public ValidatorCreatePlaceRate(IReviewManagementContext ctx)
            : base(ctx)
        {
        }
        protected override bool PreValidate(ValidationContext<CommandCreatePlaceRate> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;
            var dish = _context.PlaceRateInfos
                .AsNoTracking()
                .FirstOrDefault(x => x.Id == command.PlaceId);

            if (dish != null)
            {
                throw new EntityAlreadyExistsException("Place rate already exists.");
            }

            return base.PreValidate(context, result);
        }
    }
}
