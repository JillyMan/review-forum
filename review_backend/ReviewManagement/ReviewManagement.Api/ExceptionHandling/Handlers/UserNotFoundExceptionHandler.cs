using Microsoft.AspNetCore.Http;
using ReviewManagement.Api.Models.Responce;
using ReviewManagement.App.Exceptions;
using System;
using System.Net;

namespace ReviewManagement.Api.ExceptionHandling.Handlers
{
    public class UserNotFoundExceptionHandler : IExceptionHandler
    {
        public ExceptionObjectResult Handle(HttpContext context, Exception exception)
        {
            if (exception is UserNotFoundException notFoundException)
            {
                return new ExceptionObjectResult(new CommonExceptionResponse((int)HttpStatusCode.Unauthorized, notFoundException.Message));
            }

            return null;
        }
    }
}
