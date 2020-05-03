using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using System.Linq;

namespace ReviewManagement.App.Commands.Category
{
	public class CategoryValidatorBase<TCommandResult> : AbstractValidator<CategoryCommandBase<TCommandResult>>
	{
		private readonly IReviewManagementContext _context;

		public CategoryValidatorBase(IReviewManagementContext context)
		{
			_context = context;

			RuleFor(x => x.Name)
				.NotEmpty();
		}

		protected override bool PreValidate(ValidationContext<CategoryCommandBase<TCommandResult>> context, ValidationResult result)
		{
			var command = context.InstanceToValidate;

			var category = _context.Categories
				.AsNoTracking()
				.FirstOrDefault(x => x.Name == command.Name);

			if (category != null)
			{
				throw new EntityAlreadyExistsException();
			}

			return base.PreValidate(context, result);
		}
	}
}
