using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Medical.Persistence.ContextFactory
{
    public class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {
        public ApplicationContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<ApplicationContext>()
                .UseSqlServer(config.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("Medical.Api"));

            return new ApplicationContext(builder.Options);
        }
    }
}
