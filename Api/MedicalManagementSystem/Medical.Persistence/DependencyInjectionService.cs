using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Medical.Domain.Repositories;
using Medical.Persistence.Repositories;

namespace Medical.Persistence
{
    public static class DependencyInjectionService
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection service, IConfiguration config)
        {
            service.AddScoped<IRepositoryManager, RespositoryManager>();
            service.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
            });

            return service;
        }
    }
}
