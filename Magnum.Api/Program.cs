using Magnum.Api.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.AddServiceDefaults();


builder.Services.AddDbContext<GerichtDbContext>(options => {
    options.UseSqlServer(
        builder.Configuration["ConnectionStrings:DefaultConnection"]);
});




// Add services to the container.
builder.Services.AddScoped<IGerichtRepository, GerichtRepository>();
builder.Services.AddScoped<IZutatRepository, ZutatRepository>();
builder.Services.AddScoped<IBeigabeRepository, BeigabeRepository>();


builder.Services.AddCors(options =>
{
    options.AddPolicy("Open", builder => builder.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.MapDefaultEndpoints();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseCors("Open");

app.MapControllers();

app.Run();
