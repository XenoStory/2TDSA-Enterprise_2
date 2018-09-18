using Fiap06.Wev.MVC.Models;
using Fiap06.Wev.MVC.Units;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap06.Wev.MVC.Controllers
{
    public class ApostaController : Controller
    {
       private UnitOfWork _unit = new UnitOfWork();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var l = _unit.ConcursoRepository.Listar();
            ViewBag.list = new SelectList(l, "Numero", "Numero");

            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastrar(Aposta a)
        {
            _unit.ApostaRepository.Cadastrar(a);
            _unit.Salvar();

    

            TempData["msg"] = "Aposta cadastrada com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _unit.ApostaRepository.Listar();

            
            return View(lista);
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}