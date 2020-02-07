using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ReviewForum.Contract;
using ReviewForum.Core.DataAccess.Context;
using ReviewForum.Core.DataAccess.Interfaces;
using ReviewForum.Core.DataAccess.Repositories;
using ReviewForum.Core.Services;
using ReviewForum.Core.Services.Interfaces;
using ReviewForum.Core.Settings;

namespace ReviewForum.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDepenedencies(this IServiceCollection services)
        {
            services.AddTransient<IMongoContext, MongoContext>();
            services.AddTransient<IRepository<ThingItem>, ThingItemRepository>();
            services.AddTransient<IThingReviewService, ThingReviewService>();
            return services;
        }

        public static IServiceCollection AddCustomOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<MongoSettings>(configuration.GetSection(nameof(MongoSettings)));
            return services;
        }
    }
}