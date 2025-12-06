using HexagonalDemo.Application.Ports;
using HexagonalDemo.Application.UseCases;
using HexagonalDemo.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Inyección de dependencias (puertos → adaptadores)
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Casos de uso
builder.Services.AddScoped<GetProductUseCase>();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
