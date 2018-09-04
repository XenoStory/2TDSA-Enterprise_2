using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CompraController : Controller
    {
        private FiapBankContext _c = new FiapBankContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _c.CartoesVirtuais.Where(cv => !cv.Utilizado).ToList();

            ViewBag.listaCv = new SelectList(lista, "CartaoVirtualId", "Numero");

            return View();
        }
        
        [HttpPost]
        public ActionResult Cadastrar(Compra c)
        {
            _c.Compras.Add(c);

            // Update cv used for true
            var cv = _c.CartoesVirtuais.Find(c.CartaoVirtualId);
            cv.Utilizado = true;
            _c.Entry(cv).State = System.Data.Entity.EntityState.Modified;

            _c.SaveChanges();

            TempData["msg"] = "Registro cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            var lista = _c.Compras.Include("CartaoVirtual").ToList();

            return View(lista);
        }
    }
}