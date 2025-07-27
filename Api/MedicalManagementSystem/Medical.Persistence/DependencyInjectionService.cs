using Microsoft.Extensions.Configuration;

namespace Medical.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceProvider AddPersistenceServices(this IServiceProvider service, IConfiguration config)
        {
            return service;
        }
    }
}
