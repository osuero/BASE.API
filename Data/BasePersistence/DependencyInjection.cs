using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Data.BasePersistence
{
    public static  class DependencyInjection
    {
        public static IServiceCollection AddContextPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<BaseDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("connection string name"));
            });

            return services;
        }
    }
}
