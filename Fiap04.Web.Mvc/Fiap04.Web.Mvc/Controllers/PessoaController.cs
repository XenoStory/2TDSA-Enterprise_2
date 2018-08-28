using Fiap04.Web.Mvc.Models;
using Fiap04.Web.Mvc.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fiap04.Web.Mvc.Controllers
{
    public class PessoaController : Controller
    {
        private ImigracaoContext _context = new ImigracaoContext();
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Cadastrar(Pessoa p)
        {
            _context.Pessoas.Add(p);
            _context.SaveChanges();

            TempData["msg"] = "Cadastrado com sucesso.";

            return RedirectToAction("Cadastrar");
        }

        [HttpGet]
        public ActionResult Listar()
        {
            List<Pessoa> _list = _context.Pessoas.ToList();

            return View(_list);
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            Pessoa p = _context.Pessoas.Find(id);
            _context.Pessoas.Remove(p);
            _context.SaveChanges();

            TempData["msg"] = "Pessoa deletada com sucesso.";
            return RedirectToAction("Listar");
        }

        [HttpGet]
        public ActionResult Alterar(int id)
        {
            Pessoa p = _context.Pessoas.Find(id);

            return View(p);
        }

        [HttpPost]
        public ActionResult Alterar(Pessoa p)
        {
            _context.Entry(p).State = System.Data.Entity.EntityState.Modified; // Set to modified entity
            _context.SaveChanges();

            TempData["msg"] = "Pessoa atualizada com sucesso.";
            return RedirectToAction("Listar");
        }
    }
}