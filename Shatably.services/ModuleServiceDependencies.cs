using Microsoft.Extensions.DependencyInjection;

namespace Shatably.services
{
    public static class ModuleServiceDependencies
    {
        public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
        {
            // services.AddScoped<IAuthenticationService, AuthenticationService>();

            return services;
        }
    }
}
