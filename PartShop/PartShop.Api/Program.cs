using Microsoft.EntityFrameworkCore;
using PartShop.Domain.Models;
using PartShop.Domain.Repositories;
using PartShop.Infrastructure;
using PartShop.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<PartShopDbContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("PartShopConnection")));

builder.Services.AddScoped<IProductoRepository, ProductoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapGet("/api/productos/{idMarca}/{idModelo}", async (int idMarca, int idModelo) =>
    {
        try
        {
            using var scope = app.Services.CreateScope();
            
            var productoRepository = scope.ServiceProvider.GetRequiredService<IProductoRepository>();

            var productos = await productoRepository.GetAllByMarcaModelo(idMarca, idModelo);

            return Results.Ok(productos);
        }
        catch (Exception e)
        {
            app.Logger.LogError(e, e.Message);

            return Results.BadRequest(new ErrorResponse(e.Message));
        }
    })
    .AllowAnonymous()
    .WithName("GetProductos")
    .Produces(StatusCodes.Status200OK, typeof(List<ProductoModel>))
    .Produces(StatusCodes.Status400BadRequest, typeof(ErrorResponse));

app.MapPost("/api/productos/comprar/{idProducto}", async (int idProducto) =>
    {
        try
        {
            using var scope = app.Services.CreateScope();

            var productoRepository = scope.ServiceProvider.GetRequiredService<IProductoRepository>();

            var success = await productoRepository.BuyProducto(idProducto);

            return success ? Results.Ok("Producto comprado exitosamente") : Results.NotFound("No se encontró el producto");
        }
        catch (Exception e)
        {
            app.Logger.LogError(e, e.Message);

            return Results.BadRequest(new ErrorResponse(e.Message));
        }
    }).AllowAnonymous()
    .WithName("ComprarProducto")
    .Produces(StatusCodes.Status200OK, typeof(string))
    .Produces(StatusCodes.Status404NotFound, typeof(string))
    .Produces(StatusCodes.Status400BadRequest, typeof(ErrorResponse));

app.Run();

internal record ErrorResponse(string ErrorMessage);