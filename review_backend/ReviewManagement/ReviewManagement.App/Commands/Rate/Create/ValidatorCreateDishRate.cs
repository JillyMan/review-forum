using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Commands.Rate.Base;
using ReviewManagement.App.Exceptions;
using ReviewManagement.Domain.Entities;
using System.Linq;

namespace ReviewManagement.App.Commands.Rate.Create
{
	public class ValidatorCreateDishRate : ValidatorCreateRateBase<CommandCreateDishRate, DishRate>
    {
        public ValidatorCreateDishRate(IReviewManagementContext ctx)
            : base(ctx)
        {
        }

        protected override bool PreValidate(ValidationContext<CommandCreateDishRate> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;
            var dish = _context.DishRateInfos
                .AsNoTracking()
                .FirstOrDefault(x => x.DishId == command.DishId);

            if (dish != null)
            {
                throw new EntityAlreadyExistsException("Dish rate already exists.");
            }

            return base.PreValidate(context, result);
        }
    }
}
