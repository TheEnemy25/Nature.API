using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Identity;
using Nature.Data.Context;
using Nature.Domain.Services.Implementation;
using Nature.Domain.Services.Interfaces;
using Nature.Infrastructure.Entities;

namespace Nature.Domain
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IAnimalService, AnimalService>();
            services.AddScoped<IPlantService, PlantService>();

            services.AddIdentity<AppUser, AppRole>(config =>
            {
                config.Password.RequiredLength = 8;
                config.Password.RequireDigit = true;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.User.RequireUniqueEmail = true;
            })
            .AddEntityFrameworkStores<ApplicationDbContext>()
            .AddDefaultTokenProviders()
            .AddSignInManager<SignInManager<AppUser>>();

            return services;
        }
    }
}
