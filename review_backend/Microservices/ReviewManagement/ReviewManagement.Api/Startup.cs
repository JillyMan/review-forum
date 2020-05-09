using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Data;
using ReviewManagement.Api.AutoMapperConfig;
using ReviewManagement.Api.ExceptionHandling;
using ReviewManagement.Api.Extensions;
using ReviewManagement.Api.Filters;
using ReviewManagement.Api.Services;
using ReviewManagement.App.Infrastructure.PipelineBehaviors;
using ReviewManagement.Domain.Entities;
using System.Reflection;

namespace ReviewManagement
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAutoMapper(typeof(MapperProfile).Assembly,
                            typeof(App.AutoMapperConfig.MapperProfile).Assembly);

            services.AddMediatR(typeof(App.Commands.Category.Add.CommandCreateaCategory).GetTypeInfo().Assembly);

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ContextTransactionBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(AuditableBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
                options.ReturnHttpNotAcceptable = false;
                options.Filters.Add(typeof(ModelStateFeatureFilter));
            })
            .AddNewtonsoftJson(option =>
            {
                option.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
            })
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<App.Commands.Place.Create.Validator>());

            services.AddDbContext<IReviewManagementContext, ReviewManagementContext>(ConfigureSqlServer);
            services.AddDbContext<ReviewManagementContext>(ConfigureSqlServer); // this is required for design-time execution though dotnet ef migrations

            services.RegisterExceptionHandlers();

            services.AddMemoryCache(option =>
            {
                option.ExpirationScanFrequency = System.TimeSpan.FromMinutes(5);
            });

            services.AddTransient<EntityServiceCache<Place>>();

            var secretKey = Configuration.GetValue<string>("Jwt:Secret");
            var expirationTime = Configuration.GetValue<int>("Jwt:ExpirationTime");
            services.CustomAuthentication(Configuration);
            services.AddServices();

            services.AddControllers();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            using var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();

            var context = serviceScope.ServiceProvider.GetRequiredService<ReviewManagementContext>();
            context.Database.Migrate();
            var result = context.Database.EnsureCreated();
        }

        private void ConfigureSqlServer(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("ReviewManagement"));
        }
    }
}
