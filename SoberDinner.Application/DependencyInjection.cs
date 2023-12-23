using Microsoft.Extensions.DependencyInjection;
using SoberDinner.Application.Services.Authentication;

namespace SoberDinner.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection Addapplication(this IServiceCollection services)
        {
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }
    }
}
