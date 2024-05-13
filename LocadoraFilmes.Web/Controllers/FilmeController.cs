using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LocadoraFilmes.Web.Controllers
{
    public class FilmeController : Controller
    {
        private readonly IFilmeService filmeService;

        public FilmeController(IFilmeService service)
        {
            filmeService = service;
        }

        public ActionResult Index()
        {
            var filmes = filmeService.GetAllFilmes();
            return View(filmes);
        }

        public ActionResult Details(int id)
        {
            var filme = filmeService.GetFilmeById(id);
            if (filme == null)
                return (null);
            return View(filme);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filme filme)
        {
            if (ModelState.IsValid)
            {
                filmeService.SaveFilme(filme);
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        public ActionResult Edit(int id)
        {
            var filme = filmeService.GetFilmeById(id);
            if (filme == null)
                return (null);
            return View(filme);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Filme filme)
        {
            if (ModelState.IsValid)
            {
                filmeService.SaveFilme(filme);
                return RedirectToAction("Index");
            }
            return View(filme);
        }

        public ActionResult Delete(int id)
        {
            var filme = filmeService.GetFilmeById(id);
            if (filme == null)
                return (null);
            return View(filme);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            filmeService.DeleteFilme(id);
            return RedirectToAction("Index");
        }
    }

}
