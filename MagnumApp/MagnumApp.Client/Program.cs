using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Magnum.Shared.Extensions;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddCommonDependencies();


//builder.Services.AddScoped<IGerichtDataService, GerichtDataService>();

await builder.Build().RunAsync();
