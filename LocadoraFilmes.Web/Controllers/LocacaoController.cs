using LocadoraFilmes.Web.Interfaces;
using LocadoraFilmes.Web.Service;
using LocadoraFilmes.Web.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using LocadoraFilmes.Web.Serviços;

namespace LocadoraFilmes.Web.Controllers
{
    public class LocacaoController : Controller
    {
        private readonly ILocacaoService locacaoService;

        public LocacaoController(ILocacaoService service)
        {
            locacaoService = service;
        }

        public ActionResult Index()
        {
            var locacoes = locacaoService.GetAllLocacoes();
            return View(locacoes);
        }

        public ActionResult Details(int id)
        {
            var locacao = locacaoService.GetLocacaoById(id);
            if (locacao == null)
                return (null);
            return View(locacao);
        }


        public ActionResult Create(int id)
        {

            ViewBag.FilmeId = new SelectList(locacaoService.GetAllLocacoes(), "FilmeId", "Titulo");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                locacaoService.SaveLocacao(locacao);
                return RedirectToAction("Index");
            }
            ViewBag.FilmeId = new SelectList(locacaoService.GetAllLocacoes(), "FilmeId", "Titulo", locacao.FilmeId);
            return View(locacao);
        }

        public ActionResult Edit(int id)
        {
            var locacao = locacaoService.GetLocacaoById(id);
            if (locacao == null)
                return (null);
            ViewBag.FilmeId = new SelectList(locacaoService.GetAllLocacoes(), "FilmeId", "Titulo", locacao.FilmeId);
            return View(locacao);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Locacao locacao)
        {
            if (ModelState.IsValid)
            {
                locacaoService.SaveLocacao(locacao);
                return RedirectToAction("Index");
            }
            ViewBag.FilmeId = new SelectList(locacaoService.GetAllLocacoes(), "FilmeId", "Titulo", locacao.FilmeId);
            return View(locacao);
        }

        public ActionResult Delete(int id)
        {
            var locacao = locacaoService.GetLocacaoById(id);
            if (locacao == null)
                return (null);
            return View(locacao);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            locacaoService.DeleteLocacao(id);
            return RedirectToAction("Index");
        }
    }
}
