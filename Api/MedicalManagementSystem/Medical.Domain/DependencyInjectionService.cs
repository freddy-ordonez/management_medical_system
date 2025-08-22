using Microsoft.Extensions.DependencyInjection;

namespace Medical.Domain
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection service)
        {
            return service;
        }
    }
}
