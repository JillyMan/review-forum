using Microsoft.AspNetCore.Http;
using ReviewManagement.Api.Models.Responce;
using ReviewManagement.App.Exceptions;
using System;
using System.Net;

namespace ReviewManagement.Api.ExceptionHandling.Handlers
{
    public class EntityAlreadyExistsHandler : IExceptionHandler
    {
        public ExceptionObjectResult Handle(HttpContext context, Exception exception)
        {
            if (exception is EntityAlreadyExistsException alreadyExistsException)
            {
                return new ExceptionObjectResult(
                    new CommonExceptionResponse(
                        (int)HttpStatusCode.Conflict,
                        alreadyExistsException.Message
                        )
                    );
            }

            return null;
        }
    }
}
