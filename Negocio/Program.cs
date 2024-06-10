using Negocio.Controllers;
using Negocio.DataBaseConnection;
using Negocio.Services;
using Negocio.Interfaces;
using Negocio.Persistence;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//Dependencies
builder.Services.AddScoped<IConnection, ConnectionService>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();

//builder.Services.AddScoped<IproductService, ProductService>();

var app = builder.Build();

////Get service provider
//app.Use(async (context, next) =>
//{
//    // Resuelve el servicio Iconnection dentro del contexto de una solicitud HTTP
//    var connectionService = context.RequestServices.GetService<IConnection>();

//    // Llama al siguiente middleware en la cadena de procesamiento
//    await next();
//});




//Dependencies


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
