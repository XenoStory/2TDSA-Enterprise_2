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

            CarregarDropDown();

            return View(lista);
        }

        [HttpGet]
        public ActionResult Pesquisar(int numero)
        {
            var lista = _c.CartoesVirtuais.Where(car => car.CartaoRealId == numero).ToList();

            CarregarDropDown();

            return View("Listar", lista);
        }


        private void CarregarDropDown()
        {
            // Valores para o dropdown do frontend
            var dropList = _c.CartoesReais.ToList();
            ViewBag.listaCartoes = new SelectList(dropList, "CartaoRealId", "Numero");
        }
    }
}