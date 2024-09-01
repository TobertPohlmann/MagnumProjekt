using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Magnum.Shared.Extensions;
using MagnumApp.Client;
using Magnum.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddCommonDependencies();

await builder.Build().RunAsync();
