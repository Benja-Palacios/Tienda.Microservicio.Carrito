namespace TiendaServicions.Carrito.RemoteModel
{
    public class LibroRemote
    {
        public Guid? LibreriaMaterialId { get; set; }
        public string Titulo { get; set; }
        public DateTime? FechaPublicacion { get; set; }
        public Guid? AutorLibro { get; set; }
        public String Genero { get; set; }
        public double Precio { get; set; }
    }
}
