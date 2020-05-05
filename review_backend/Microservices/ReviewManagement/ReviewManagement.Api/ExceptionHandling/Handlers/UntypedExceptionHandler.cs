using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using ReviewManagement.Api.Models.Responce;
using System;
using System.Net;

namespace ReviewManagement.Api.ExceptionHandling.Handlers
{
    public class UntypedExceptionHandler : IExceptionHandler
    {
        private readonly IHostingEnvironment _environment;

        public UntypedExceptionHandler(IHostingEnvironment environment)
        {
            _environment = environment;
        }

        public ExceptionObjectResult Handle(HttpContext context, Exception exception)
        {
            var internalErrorMessage = _environment.IsDevelopment() ? exception.ToString() : "An error has occured at the server";
            return new ExceptionObjectResult(new CommonExceptionResponse((int)HttpStatusCode.InternalServerError, internalErrorMessage));
        }
    }
}
