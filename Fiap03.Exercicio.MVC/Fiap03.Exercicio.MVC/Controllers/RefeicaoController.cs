using Fiap03.Exercicio.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap03.Exercicio.MVC.Controllers
{
    public class RefeicaoController : Controller
    {
        private static List<Refeicao> _lista = new List<Refeicao>();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            var lista = new List<string>();
            lista.Add("Coca-cola");
            lista.Add("Pepsi");
            lista.Add("Vodka com Energético");

            ViewBag.listaBebidas = new SelectList(lista);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Refeicao r)
        {
            TempData["msg"] = "Refeição cadastrada com sucesso. Bom apetite!";
            _lista.Add(r);
            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }
    }
}