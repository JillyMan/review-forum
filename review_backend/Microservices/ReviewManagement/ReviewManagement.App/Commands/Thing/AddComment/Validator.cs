﻿using System.Linq;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.EntityFrameworkCore;
using Review.App.Infrastructure;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Resources;

namespace ReviewManagement.App.Commands.Thing.AddComment
{
    public class Validator : AbstractValidator<Command>
    {
        private IReviewManagementContext _context;

        public Validator(IReviewManagementContext context)
        {
            _context = context;

            RuleFor(x => x.Text)
                .MinimumLength(15)
                .NotEmpty();
        }

        protected override bool PreValidate(ValidationContext<Command> context, ValidationResult result)
        {
            var command = context.InstanceToValidate;

            var thing = _context.Things.AsNoTracking().FirstOrDefault(x => x.Id == command.ThingId);
            if (thing == null)
            {
                throw new EntityNotFoundException();
            }

            //todo: add user check.

            return true;
        }

    }
}