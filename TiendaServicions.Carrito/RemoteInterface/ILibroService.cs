using TiendaServicions.Carrito.RemoteModel;

namespace TiendaServicions.Carrito.RemoteInterface
{
    public interface ILibroService
    {
        Task<(bool resultado, LibroRemote Libro, string ErrorMessage)>
            GetLibro(Guid LibroId);
    }
}
