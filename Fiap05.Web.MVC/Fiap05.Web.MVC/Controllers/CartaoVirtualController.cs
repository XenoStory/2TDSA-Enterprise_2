using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoVirtualController : Controller
    {
        private FiapBankContext _c = new FiapBankContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = _c.CartoesReais.ToList();

            ViewBag.listaCr = new SelectList(lista, "CartaoRealId", "Numero");

            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CartaoVirtual cv)
        {
            _c.CartoesVirtuais.Add(cv);
            _c.SaveChanges();
            TempData["msg"] = "Registro cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            // Include: preenche o objeto da outra tabela com seus valores
            var lista = _c.CartoesVirtuais.Include("CartaoReal").ToList();

            return View(lista);
        }
    }
}