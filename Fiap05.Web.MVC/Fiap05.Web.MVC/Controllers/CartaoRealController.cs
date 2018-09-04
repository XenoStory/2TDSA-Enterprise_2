using Fiap05.Web.MVC.Models;
using Fiap05.Web.MVC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap05.Web.MVC.Controllers
{
    public class CartaoRealController : Controller
    {
        private FiapBankContext _c = new FiapBankContext();

        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(CartaoReal cr)
        {
            _c.CartoesReais.Add(cr);
            _c.SaveChanges();

            TempData["msg"] = "Cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<CartaoReal> _lista = _c.CartoesReais.ToList();

            return View(_lista);
        }

        [HttpGet]
        public ActionResult Editar(int id)
        {
            CartaoReal cr = _c.CartoesReais.Find(id);

            return View(cr);
        }

        [HttpPost]
        public ActionResult Editar(CartaoReal cr)
        {
            _c.Entry(cr).State = System.Data.Entity.EntityState.Modified; // Set to modified entity state
            _c.SaveChanges();

            TempData["msg"] = "Cartão real atualizado com sucesso.";

            return RedirectToAction("Listar");
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            CartaoReal cr = _c.CartoesReais.Find(id);
            _c.CartoesReais.Remove(cr);
            _c.SaveChanges();

            TempData["msg"] = "Registro deletado com sucesso.";

            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Pesquisar(string number)
        {
            IList<CartaoReal> cr;
            if (number != "")
            {
                long num = Convert.ToInt64(number);
                cr = _c.CartoesReais.Where(car => car.Numero == num).ToList();
            }
            else
            {
                cr = _c.CartoesReais.ToList();
            }

            return View("Listar", cr);
        }
    }
}