using Magnum.Shared.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Magnum.Shared.Extensions;

public static class Extensions
{ 
    public static IServiceCollection AddCommonDependencies(this IServiceCollection services)
    {
        services.AddHttpClient<IGerichtDataService, GerichtDataService>(client => client.BaseAddress = new Uri("https://localhost:7033"));
        services.AddHttpClient<IZutatDataService, ZutatDataService>(client => client.BaseAddress = new Uri("https://localhost:7033"));
        services.AddHttpClient<IBeigabeDataService, BeigabeDataService>(client => client.BaseAddress = new Uri("https://localhost:7033"));
        services.AddScoped<ApplicationState>();
        return services;
    }
}
