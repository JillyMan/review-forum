using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using ReviewManagement.Api.ExceptionHandling.Handlers;
using ReviewManagement.App.Infrastructure.Token;
using ReviewManagement.App.Services.User;
using System.Text;
using System.Threading.Tasks;

namespace ReviewManagement.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
        public static void RegisterExceptionHandlers(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IExceptionHandler, UserNotFoundExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, ValidationExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, EntityAlreadyExistsHandler>();
            serviceCollection.AddTransient<IExceptionHandler, EntityNotFoundExceptionHandler>();
            serviceCollection.AddTransient<IExceptionHandler, UntypedExceptionHandler>();
        }

        public static IServiceCollection CustomAuthentication(this IServiceCollection serviceCollection, Microsoft.Extensions.Configuration.IConfiguration configuration)
        {
            var jwtSetting = new JwtSetting(
                configuration["Jwt:Secret"],
                int.Parse(configuration["Jwt:ExpirationTime"]),
                configuration["Jwt:Issuer"]
            );

            serviceCollection.AddSingleton(jwtSetting);
            serviceCollection.AddScoped<ITokenService, JwtTokenProvider>();

            serviceCollection.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = jwtSetting.Issuer,

                    ValidateAudience = true,
                    ValidAudience = jwtSetting.Issuer,

                    ValidateLifetime = false,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSetting.Secret)),
                };

                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
            });

            return serviceCollection;
        }

        public static IServiceCollection AddServices(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddTransient<IUserService, UserService>();

            return serviceCollection;
        }
    }
}
