using _02.Fiap.WebApplication.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _02.Fiap.WebApplication.MVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            var url = "";
            var msg = "Login ou senha inválidos!";
            if(user.Username.ToUpper() == "FIAP" && user.Password == "FIAP123")
            {
                url = "Sucesso";
                msg = "Login efetuado com sucesso!";
                ViewBag.username = user.Username;
            }

            TempData["message"] = msg;
            return View(url);
        }

        [HttpGet]
        public ActionResult Sucesso()
        {
            var url = "";

            if(TempData["message"] == null)
            {
                url = "Login";
            }

            return View(url);
        }
    }
}