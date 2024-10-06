using EduHubAPI.CA.Application.Interfaces;
using EduHubAPI.CA.Infrastructure.Resources.Services;
using Microsoft.Extensions.DependencyInjection;

namespace EduHubAPI.CA.Infrastructure.Resources
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddResourcesInfrastructure(this IServiceCollection services)
        {
            services.AddSingleton<ITranslator, Translator>();

            return services;
        }
    }
}
