using AccessManagement.App.Infrastructure.Token;
using AccessManagement.App.Services.User;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;


namespace AccessManagement.Api.Extensions
{
    public static class IServiceCollectionExtensions
    {
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
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtSetting.Secret)),
                };
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
