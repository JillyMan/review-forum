using Microsoft.Extensions.DependencyInjection;
using ReviewManagement.Api.ExceptionHandling.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void RegisterExceptionHandlers(IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IExceptionHandler, ValidationExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, UntypedExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, EntityNotFoundExceptionHandler>();
        }
    }
}
