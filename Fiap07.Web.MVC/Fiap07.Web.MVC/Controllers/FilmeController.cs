using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class FilmeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var selectList = _unit.CategoriaRepository.Listar();
            ViewBag.selectList = new SelectList(selectList, "CategoriaId", "Nome");
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Filme f)
        {
            _unit.FilmeRepository.Cadastrar(f);
            _unit.Salvar();

            TempData["msg"] = "Filme cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_unit.FilmeRepository.Listar());
        }

        [HttpGet]
        public ActionResult Pesquisar(string data)
        {
            return RedirectToAction("Listar", _unit.FilmeRepository.BuscarPor(f => f.Nome == data).ToList());
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}