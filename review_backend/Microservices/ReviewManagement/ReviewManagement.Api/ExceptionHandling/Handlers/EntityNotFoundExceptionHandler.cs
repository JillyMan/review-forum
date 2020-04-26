using Microsoft.AspNetCore.Http;
using ReviewManagement.Api.Models.Responce;
using ReviewManagement.App.Exceptions;
using System;
using System.Net;

namespace ReviewManagement.Api.ExceptionHandling.Handlers
{
    public class EntityNotFoundExceptionHandler : IExceptionHandler
    {
        public ExceptionObjectResult Handle(HttpContext context, Exception exception)
        {
            if (exception is EntityNotFoundException notFoundException)
            {
                return new ExceptionObjectResult(new CommonExceptionResponse((int)HttpStatusCode.NotFound, notFoundException.Message));
            }

            return null;
        }
    }
}
