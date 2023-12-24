using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SoberDinner.Application.Common.Interfaces.Authentication;
using SoberDinner.Application.Common.Interfaces.Services;
using SoberDinner.Infrastructure.Authentication;
using SoberDinner.Infrastructure.Services;

namespace SoberDinner.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            ConfigurationManager configuration)
        {
            services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.Sectionname));
            services.AddSingleton<IJwtTokenGenerator, JwtTokenGenerator>();
            services.AddSingleton<IDateTimeProvider, DateTimeProvider>();
            return services;
        }
    }
}
