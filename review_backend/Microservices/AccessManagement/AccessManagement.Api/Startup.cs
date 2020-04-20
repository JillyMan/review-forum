using AutoMapper;
using AccessManagement.Api.Extensions;
using AccessManagement.App;
using AccessManagement.App.Infrastructure.Token;
using AccessManagement.Data;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AccessManagement.Api.AutoMapperProfiler;

namespace AccessManagement.Api
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
            services.AddAutoMapper(typeof(MapperProfile).Assembly);

            services.AddDbContext<IAccessManagementContext, AccessManagementContext>(ConfigureSqlServer);

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

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();
            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void ConfigureSqlServer(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("AccessManagement"));
        }
    }
}
