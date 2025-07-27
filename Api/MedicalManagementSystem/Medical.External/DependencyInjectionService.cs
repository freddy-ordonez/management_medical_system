using Microsoft.Extensions.Configuration;

namespace Medical.External
{
    public static class DependencyInjectionService
    {
        public static IServiceProvider AddExternalServices(this IServiceProvider service, IConfiguration configuration)
        {
            return service;
        }
    }
}
