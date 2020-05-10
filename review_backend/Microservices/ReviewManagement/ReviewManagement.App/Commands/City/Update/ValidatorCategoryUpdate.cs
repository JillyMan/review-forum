using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using System.Linq;

namespace ReviewManagement.App.Commands.City.Update
{
	public class ValidatorUpdateCity : AbstractValidator<CommandUpdateCity>
	{
		private readonly IReviewManagementContext _context;

		public ValidatorUpdateCity(IReviewManagementContext context)
		{
			_context = context;

			RuleFor(x => x.Name)
				.NotEmpty();
		}

		protected override bool PreValidate(ValidationContext<CommandUpdateCity> context, ValidationResult result)
		{
			var command = context.InstanceToValidate;

			if (command.CountryId.HasValue && 
				_context.Countries.AsNoTracking().FirstOrDefault(x => x.Id == command.CountryId) == null)
			{
				result.Errors.Add(new ValidationFailure("CountryId", "Country not found for this city"));
			}

			return base.PreValidate(context, result);
		}
	}
}