using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraFilmes.Web.Controllers
{
    public class ClienteController : Controller
    {
        private readonly IClienteService clienteService;

        public ClienteController(IClienteService service)
        {
            clienteService = service;
        }

        public ActionResult Index()
        {
            var clientes = clienteService.GetAllClientes();
            return View(clientes);
        }

        public ActionResult Details(int id)
        {
            var cliente = clienteService.GetClienteById(id);
            if (cliente == null)
                return (null);
            return View(cliente);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteService.SaveCliente(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Edit(int id)
        {
            var cliente = clienteService.GetClienteById(id);
            if (cliente == null)
                return (null);
            return View(cliente);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                clienteService.SaveCliente(cliente);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        public ActionResult Delete(int id)
        {
            var cliente = clienteService.GetClienteById(id);
            if (cliente == null)
                return (null);
            return View(cliente);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            clienteService.DeleteCliente(id);
            return RedirectToAction("Index");
        }
    }

}
