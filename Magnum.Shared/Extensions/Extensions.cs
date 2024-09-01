using MagnumApp.Client.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Magnum.Shared.Extensions;

public static class Extensions
{ 
    public static IServiceCollection AddCommonDependencies(this IServiceCollection services)
    {
        services.AddHttpClient<IGerichtDataService, GerichtDataService>(client => client.BaseAddress = new Uri("http://localhost:5188"));
        services.AddHttpClient<IZutatenDataService, ZutatenDataService>(client => client.BaseAddress = new Uri("http://localhost:5188"));

        return services;
    }
}
