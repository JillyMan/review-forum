using Microsoft.Extensions.DependencyInjection;
using ReviewManagement.Api.ExceptionHandling.Handlers;

namespace ReviewManagement.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void RegisterExceptionHandlers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IExceptionHandler, ValidationExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, EntityNotFoundExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, UntypedExceptionHandler>();
        }
    }
}
