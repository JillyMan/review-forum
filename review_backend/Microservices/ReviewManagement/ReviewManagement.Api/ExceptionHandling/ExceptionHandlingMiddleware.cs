using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using ReviewManagement.Api.ExceptionHandling.Handlers;
using ReviewManagement.Api.Extensions;
using ReviewManagement.Api.Models.Responce;
using System;
using System.Net;
using System.Threading.Tasks;

namespace ReviewManagement.Api.ExceptionHandling
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
        }


        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next.Invoke(context);
            }
            catch (Exception ex)
            {
                await HandleExceptionAsync(context, ex);
            }
        }

        private async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            var response = context.Response;
            var statusCode = (int)HttpStatusCode.InternalServerError;

            var exceptionHandlers = context.RequestServices.GetServices<IExceptionHandler>();

            ExceptionObjectResult result = null;

            foreach (var exceptionHandler in exceptionHandlers)
            {
                result = exceptionHandler.Handle(context, exception);
                if (result != null)
                {
                    break;
                }
            }

            response.StatusCode = statusCode;
            await context.WriteResultAsync(result);
        }
    }
}
