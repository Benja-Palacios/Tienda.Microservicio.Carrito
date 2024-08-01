namespace TiendaServicions.Carrito.Aplicaciones
{
    public class CarritoDto
    {
        public int CarritoId { get; set; }
        public DateTime? FechaCreacionSesion { get; set; }
        public List<CarritoDetalleDdto> ListaDeProductos { get; set; }
    }
}
