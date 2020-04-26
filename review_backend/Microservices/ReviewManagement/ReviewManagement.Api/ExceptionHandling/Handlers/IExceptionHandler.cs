using Microsoft.AspNetCore.Http;
using ReviewManagement.Api.Models.Responce;
using System;

namespace ReviewManagement.Api.ExceptionHandling.Handlers
{
    public interface IExceptionHandler
    {
        ExceptionObjectResult Handle(HttpContext context, Exception exception);
    }
}
