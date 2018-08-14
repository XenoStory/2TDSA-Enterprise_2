using _02.Fiap.WebApplication.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.WebApplication.MVC.Controllers
{
    public class ShowController : Controller
    {
        // GET: Show
        [HttpGet] // Carrega a página
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost] // Recupera os dados do formulário
        public ActionResult Cadastrar(Show show)
        {
            ViewBag.banda = show.Banda;
            TempData["msg"] = "Show cadastrado com sucesso.";

            return View(show); // Envia valores para a página
            // return Content(show.Banda); // Retorna um texto
        }
    }
}