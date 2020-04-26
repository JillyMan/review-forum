using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ReviewManagement.Api.Features;
using ReviewManagement.Api.Models.Responce;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ReviewManagement.Api.ExceptionHandling.Handlers
{
    public class ValidationExceptionHandler : IExceptionHandler
    {
        public ExceptionObjectResult Handle(HttpContext context, Exception exception)
        {
            ModelStateDictionary modelState = context.Features.Get<ModelStateFeature>()?.ModelState;

            var validationErrors = new List<string>();
            if (modelState != null && !modelState.IsValid)
            {
                validationErrors = modelState.Values.SelectMany(x => x.Errors.Select(y => y.ErrorMessage)).ToList();
            }

            if (exception is FluentValidation.ValidationException validationException)
            {
                validationErrors = validationException.Errors.Select(x => x.ErrorMessage).ToList();
            }

            if (validationErrors.Any())
            {
                return new ExceptionObjectResult(new ValidationExceptionResponse(validationErrors, "The request is not valid."));
            }

            return null;
        }
    }
}
