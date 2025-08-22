using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Medical.Application
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            var mapper = new MapperConfiguration(config =>
            {
                config.AddMaps(Assembly.GetExecutingAssembly());
            });

            services.AddSingleton(mapper.CreateMapper());

            return services;
        }
    }
}
