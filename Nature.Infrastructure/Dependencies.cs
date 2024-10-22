using System.Reflection;
using Microsoft.Extensions.DependencyInjection;

namespace Nature.Infrastructure
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(x => x.AddMaps(typeof(Dependencies).Assembly), Assembly.Load("Nature.Application"));

            return services;
        }
    }
}
