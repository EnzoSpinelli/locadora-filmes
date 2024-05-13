using LocadoraFilmes.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraFilmes.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private IUsuarioService usuarioService;

        public UsuarioController(IUsuarioService service)
        {
            usuarioService = service;
        }

        public ActionResult Index()
        {
            var usuarios = usuarioService.GetAllUsuarios();
            return View(usuarios);
        }

    }
}
