using Microsoft.EntityFrameworkCore;
using Nature.Data.Context;
using Nature.Data.Entities;
using Nature.Data.Infrastructure;
using Nature.Domain.Services.Implementation;
using Nature.Domain.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder
        .WithOrigins("http://localhost:3000")
        .AllowAnyHeader()
        .AllowAnyMethod()
        .AllowCredentials();
    });
});

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IBaseRepository<Animal>, BaseRepository<Animal>>();
builder.Services.AddScoped<IBaseRepository<Plant>, BaseRepository<Plant>>();

builder.Services.AddScoped<IPlantService, PlantService>();
builder.Services.AddScoped<IAnimalService, AnimalService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();