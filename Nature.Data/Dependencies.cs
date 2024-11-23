using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nature.Data.Context;
using Nature.Data.Infrastructure;
using Nature.Infrastructure.Entities;

namespace Nature.Data
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterRepositories(this IServiceCollection services)
        {
            services.AddScoped<IBaseRepository<Animal>, BaseRepository<Animal>>();
            services.AddScoped<IBaseRepository<Habitat>, BaseRepository<Habitat>>();
            services.AddScoped<IBaseRepository<Observation>, BaseRepository<Observation>>();
            services.AddScoped<IBaseRepository<Plant>, BaseRepository<Plant>>();

            return services;
        }

        public static IServiceCollection RegisterContext(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("NatureDb")));

            return services;
        }
    }
}