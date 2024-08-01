namespace TiendaServicions.Carrito.Aplicaciones
{
    public class CarritoDetalleDdto
    {
        public Guid? LibroId { get; set; }
        public string TituloLibro { get; set; }
        public Guid? AutorLibro { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public String Genero { get; set; }
        public double Precio { get; set; }

    }
}
