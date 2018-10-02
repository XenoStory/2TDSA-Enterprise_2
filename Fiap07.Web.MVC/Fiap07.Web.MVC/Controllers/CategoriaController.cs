using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap07.Web.MVC.Controllers
{
    public class CategoriaController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();
     
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Categoria c)
        {
            _unit.CategoriaRepository.Cadastrar(c);
            _unit.Salvar();

            TempData["msg"] = "Categoria cadastrada com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        protected override void Dispose(bool disposing)
        {
            _unit.Dispose();
            base.Dispose(disposing);
        }
    }
}