using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace EduHubAPI.CA.Application
{
    public static class ServiceRegistration
    {
        public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
        {
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(ServiceRegistration).Assembly));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());

            return services;
        }
    }
}
