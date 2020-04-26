using AutoMapper;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Review.App.Infrastructure;
using Review.Data;
using ReviewManagement.Api.AutoMapperConfig;
using ReviewManagement.Api.ExceptionHandling;
using ReviewManagement.Api.Extensions;
using ReviewManagement.Api.Filters;
using ReviewManagement.App.Infrastructure.PipelineBehaviors;
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

            services.AddMediatR(typeof(App.Commands.Category.Add.Command).GetTypeInfo().Assembly);
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(ContextTransactionBehavior<,>));
            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestValidationBehavior<,>));

            services.AddMvc(options =>
            {
                options.EnableEndpointRouting = false;
                options.Filters.Add(typeof(ModelStateFeatureFilter));
            })
            .AddFluentValidation(fv => fv.RegisterValidatorsFromAssemblyContaining<App.Commands.Thing.AddComment.Validator>());

            services.AddDbContext<IReviewManagementContext, ReviewManagementContext>(ConfigureSqlServer);
            services.AddDbContext<ReviewManagementContext>(ConfigureSqlServer); // this is required for design-time execution though dotnet ef migrations

            services.RegisterExceptionHandlers();

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
        }

        private void ConfigureSqlServer(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("ReviewManagement"));
        }
    }
}
