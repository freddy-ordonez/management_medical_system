using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Medical.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection service, IConfiguration config)
        {
            service.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(config["DefaultConnection"]);
            });

            return service;
        }
    }
}
