using Microsoft.Extensions.DependencyInjection;
using OnionArchitectureGuide.Application.Implementation;
using OnionArchitectureGuide.Persistence;

namespace OnionArchitectureGuide.DependencyManager
{
    public static class DependencyManager
    {
        public static void RegisterApplicationDependencies(this IServiceCollection services)
        {
            services.AddApplicationServices();
        }

        public static void RegisterInfrastructureDependencies(this IServiceCollection services, string connectionString)
        {
            services.AddInfrastructureServices(connectionString);
        }
    }
}
