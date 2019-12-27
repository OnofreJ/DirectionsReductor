namespace DirectionsReductor.Application.Services.DependencyInjection
{
    using DirectionsReductor.Application.Services.Reducer;
    using DirectionsReductor.Application.Services.Validation;
    using Microsoft.Extensions.DependencyInjection;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    [ExcludeFromCodeCoverage]
    public static class ServiceExtensions
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddSingleton<IValidationService, ValidationService>()
                .AddSingleton<IReducerService, ReducerService>();

            return services;
        }

        public static List<string> Splice(this List<string> source, int index, int count)
        {
            source.RemoveRange(index, count);

            return source;
        }
    }
}