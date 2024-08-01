using MediatR;
using Microsoft.EntityFrameworkCore;
using TiendaServicions.Carrito.Persistencia;
using TiendaServicions.Carrito.RemoteInterface; // Asegúrate de incluir este espacio de nombres
using TiendaServicions.Carrito.RemoteServices; // Asegúrate de incluir este espacio de nombres

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Registro de MediatR
builder.Services.AddMediatR(typeof(Program).Assembly); // Registra MediatR utilizando el assembly donde se encuentra Program

// Registro de ILibroService y su implementación
builder.Services.AddScoped<ILibroService, LibrosService>(); // Registra la implementación del servicio

// Registro de IHttpClientFactory
builder.Services.AddHttpClient("Libros", client =>
{
    client.BaseAddress = new Uri(builder.Configuration["Services:Libros"]); // Configura la URL base de la API
});


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CarritoContexto>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

builder.Services.AddCors(options => {
    options.AddPolicy("NuevaPolitica", app => {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("NuevaPolitica");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
