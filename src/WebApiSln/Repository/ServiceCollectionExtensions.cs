using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repository.Entity;

namespace Repository
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepository(this IServiceCollection serviceCollection, IConfiguration configuration)
        {
            serviceCollection
                .AddDbContext<WebApiDbContext>(
                    options => options.UseSqlServer(
                        configuration.GetConnectionString("DefaultConnection")));
            
            return serviceCollection;
        }
    }
}
