using Microsoft.Extensions.DependencyInjection;

namespace Nature.Application
{
    public static class Dependencies
    {
        public static IServiceCollection RegisterMediatRAndHanlders(this IServiceCollection services)
        {
            services.AddMediatR(m =>
                m.RegisterServicesFromAssembly(typeof(Dependencies).Assembly));

            return services;
        }

        public static IServiceCollection RegisterValidators(this IServiceCollection services)
        {
            //services.AddFluentValidationAutoValidation(m =>
            //    m.ValidationStrategy = ValidationStrategy.Annotations);

            //services.AddScoped<IValidator<CreateActorCommand>, CreateActorCommandValidator>();
            //services.AddScoped<IValidator<DeleteActorCommand>, DeleteActorCommandValidator>();
            //services.AddScoped<IValidator<UpdateActorCommand>, UpdateActorCommandValidator>();
            //services.AddScoped<IValidator<GetActorByIdQuery>, GetActorByIdQueryValidator>();

            //services.AddScoped<IValidator<CreateMovieCommand>, CreateMovieCommandValidator>();
            //services.AddScoped<IValidator<DeleteMovieCommand>, DeleteMovieCommandValidator>();
            //services.AddScoped<IValidator<UpdateMovieCommand>, UpdateMovieCommandValidator>();
            //services.AddScoped<IValidator<GetMovieByIdQuery>, GetMovieByIdQueryValidator>();


            return services;
        }
    }
}
