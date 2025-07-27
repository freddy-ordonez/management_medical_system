namespace Medical.Domain
{
    public static class DependencyInjectionService
    {
        public static IServiceProvider AddDomainServices(this IServiceProvider service)
        {
            return service;
        }
    }
}
