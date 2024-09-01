using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

//builder.Services.AddScoped<IGerichtDataService, GerichtDataService>();

await builder.Build().RunAsync();
