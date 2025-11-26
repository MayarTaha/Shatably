using Microsoft.Extensions.DependencyInjection;


namespace Shatably.Infrastructure
{
    public static class ModuleInfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {

            // services.AddTransient<IPaginationService, PaginationService>();

            //  services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            return services;
        }
    }
}
