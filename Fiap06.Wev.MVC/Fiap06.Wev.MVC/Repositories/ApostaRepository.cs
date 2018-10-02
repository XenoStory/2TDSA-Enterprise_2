using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap06.Wev.MVC.Models;
using Fiap06.Wev.MVC.Persistence;

namespace Fiap06.Wev.MVC.Repositories
{
    public class ApostaRepository : IApostaRepository
    {
        private FiapSenaContext _c;

        public ApostaRepository(FiapSenaContext c)
        {
            _c = c;
        }

        public void Atualizar(Aposta p)
        {
            _c.Entry(p).State = EntityState.Modified;
        }

        public IList<Aposta> BuscarPor(Expression<Func<Aposta, bool>> filtro)
        {
            return _c.Apostas.Where(filtro).ToList();
        }

        public Aposta BuscarPorNumero(int n)
        {
            return _c.Apostas.Find(n);
        }

        public void Cadastrar(Aposta p)
        {
            _c.Apostas.Add(p);
        }

        public void Excluir(int n)
        {
            var a = BuscarPorNumero(n);
            _c.Apostas.Remove(a);
        }

        public IList<Aposta> Listar()
        {
            return _c.Apostas.Include("Concurso").ToList();
        }
    }
}