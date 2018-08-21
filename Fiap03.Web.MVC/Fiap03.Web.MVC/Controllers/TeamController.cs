using Fiap03.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap03.Web.MVC.Controllers
{
    public class TeamController : Controller
    {
        // Simular o banco de dados (memória)
        private static List<Team> _lista = new List<Team>();

        [HttpGet]
        public ActionResult Listar()
        {
            return View(_lista);
        }

        [HttpGet]
        public ActionResult Cadastrar()
        {
            // Criar a lista com as opções de liga (já que não temos o db ainda) com as opções de liga
            var lista = new List<string>();
            lista.Add("Global");
            lista.Add("Regional");
            lista.Add("Estadual");

            // Enviar lista para a view
            ViewBag.listaLiga = new SelectList(lista);
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Team t)
        {
            // Mensagem de sucesso
            TempData["msg"] = "Time registrado com sucesso. Cuidado com o XenoBoy, ele é brabo!";
            _lista.Add(t);
            // Redirect para não cadastrar vários dados repetidos ao atualizar página
            return RedirectToAction("Cadastrar");
        }
    }
}