using Microsoft.AspNetCore.Mvc.Filters;
using ReviewManagement.Api.Features;
using System;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Filters
{
    public class ModelStateFeatureFilter : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (!context.ModelState.IsValid)
            {
                context.HttpContext.Features.Set(new ModelStateFeature(context.ModelState));

                // throw an exception, that middleware handles it and formats response in a generic fashion
                throw new InvalidOperationException("Model State is not valid.");
            }

            await next();
        }
    }
}
