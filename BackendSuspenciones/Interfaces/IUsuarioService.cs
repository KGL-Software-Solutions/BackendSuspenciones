using BackendSuspenciones.Models;

namespace BackendSuspenciones.Interfaces
{
    public interface IUsuarioService
    {
        List<Usuario> ObtenerTodos();
        Usuario? ObtenerPorId(int id);
    }
}
