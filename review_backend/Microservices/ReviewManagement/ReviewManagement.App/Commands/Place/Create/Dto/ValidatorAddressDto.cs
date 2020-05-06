using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using System.Linq;

namespace ReviewManagement.App.Commands.Place.Create.Dto
{
	public class ValidatorAddressDto : AbstractValidator<AddressDto>
    {
        private readonly IReviewManagementContext _context;

        public ValidatorAddressDto(IReviewManagementContext context)
        {
            _context = context;

            RuleFor(x => x.Longitude)
                .Must(x => x >= -180.0f && x <= 180.0f);

            RuleFor(x => x.Latitude)
                .Must(x => x >= -180.0f && x <= 180.0f);

            RuleFor(x => x.Street)
                .NotEmpty();
        }

        protected override bool PreValidate(ValidationContext<AddressDto> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            if (_context.Cities.AsNoTracking().FirstOrDefault(x => x.Id == command.CityId) == null)
            {
                throw new EntityNotFoundException($"City with id: {command.CityId} not found");
            }

            if (_context.Countries.AsNoTracking().FirstOrDefault(x => x.Id == command.CountryId) == null)
            {
                throw new EntityNotFoundException($"Country with id: {command.CountryId} not found");
            }

            return true;
        }

    }
}
