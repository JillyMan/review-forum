using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Infrastructure;
using System.Linq;

namespace ReviewManagement.App.Commands.City.Create
{
	public class ValidatorCreateCity : AbstractValidator<CommandCreateCity>
	{
		private readonly IReviewManagementContext _context;

		public ValidatorCreateCity(IReviewManagementContext _context)
		{
			RuleFor(x => x.Name)
				.NotEmpty();
		}

		protected override bool PreValidate(ValidationContext<CommandCreateCity> context, ValidationResult result)
		{
			var command = context.InstanceToValidate;
			if (_context.Countries
				.AsNoTracking()
				.FirstOrDefault(x => x.Id == command.CountryId) == null)
			{
				result.Errors.Add(new ValidationFailure("CountryId", "Country not found for this city"));
			}

			return base.PreValidate(context, result);
		}
	}
}
