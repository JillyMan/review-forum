using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ReviewForum.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDepenedencies(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddCustomOptions(this IServiceCollection services, IConfiguration configuration)
        {
            //services.Configure<MongoSettings>(configuration.GetSection(nameof(MongoSettings)));
            return services;
        }
    }
}