using Microsoft.Extensions.DependencyInjection;

namespace DependencyInjection.XmlExtensions
{
    public static class ServiceCollectionServiceConfigExtensions
    {
        public static IServiceCollection AddServiceConfig(this IServiceCollection services)
        {

            return services;
        }

        public static IServiceCollection AddServiceConfig(this IServiceCollection services, string filename)
        {

            return services;
        }

        public static IServiceCollection AddServiceConfig(this IServiceCollection services, string fileDirectory, string filename)
        {

            return services;
        }

    }
}