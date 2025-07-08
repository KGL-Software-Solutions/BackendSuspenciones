using BackendSuspenciones.Interfaces;
using BackendSuspenciones.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendSuspenciones.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        public ActionResult<List<Usuario>> Get() => _usuarioService.ObtenerTodos();

        [HttpGet("{id}")]
        public ActionResult<Usuario> Get(int id)
        {
            var usuario = _usuarioService.ObtenerPorId(id);
            if (usuario == null) return NotFound();
            return usuario;
        }
    }
}
