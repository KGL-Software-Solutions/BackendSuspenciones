using BackendSuspenciones.Interfaces;
using BackendSuspenciones.Models;

namespace BackendSuspenciones.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly List<Usuario> _usuarios = new()
    {
        new Usuario { Id = 1, Nombre = "Juan" },
        new Usuario { Id = 2, Nombre = "Ana" }
    };

        public List<Usuario> ObtenerTodos() => _usuarios;

        public Usuario? ObtenerPorId(int id) =>
            _usuarios.FirstOrDefault(u => u.Id == id);
    }
}
