using Fiap06.Wev.MVC.Models;
using Fiap06.Wev.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Wev.MVC.Controllers
{
    public class ConcursoController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Concurso c)
        {
            _unit.ConcursoRepository.Cadastrar(c);
            _unit.Salvar();

            TempData["msg"] = "Concurso cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}