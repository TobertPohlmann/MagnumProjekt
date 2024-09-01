using MagnumApp.Components;
using MagnumApp.Client.Services;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();


//Client dependencies
builder.Services.AddHttpClient<IGerichtDataService, GerichtDataService>(client => client.BaseAddress = new Uri("http://localhost:5188"));
builder.Services.AddHttpClient<IZutatenDataService, ZutatenDataService>(client => client.BaseAddress = new Uri("http://localhost:5188"));

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(MagnumApp.Client._Imports).Assembly);

app.Run();