using Microsoft.EntityFrameworkCore;
using TiendaServicions.Carrito.Modelo;

namespace TiendaServicions.Carrito.Persistencia
{
    public class CarritoContexto: DbContext
    {
        public CarritoContexto(DbContextOptions<CarritoContexto> options) : base(options) 
        {
        
        }

        public DbSet<CarritoSesion> CarritoSesiones { get; set; }
        public DbSet<CarritoSesionDetalle> CarritoSesionDetalle { get; set; }
    }
}
