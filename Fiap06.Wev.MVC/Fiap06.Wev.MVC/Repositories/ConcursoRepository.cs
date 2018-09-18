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
    public class ConcursoRepository : IConcursoRepository
    {
        private FiapSenaContext _c;

        public ConcursoRepository(FiapSenaContext c)
        {
            _c = c;
        }
        public void Atualizar(Concurso c)
        {
            _c.Entry(c).State = EntityState.Modified;
        }

        // Generic filter
        public IList<Concurso> BuscarPor(Expression<Func<Concurso, bool>> filtro)
        {
            return _c.Concursos.Where(filtro).ToList();
        }

        public Concurso BuscarPorNumero(int n)
        {
            return _c.Concursos.Find(n);
        }

        public void Cadastrar(Concurso c)
        {
            _c.Concursos.Add(c);
        }

        public void Excluir(int n)
        {
            var c = _c.Concursos.Find(n);
            _c.Concursos.Remove(c);
        }

        public IList<Concurso> Listar()
        {
            return _c.Concursos.ToList();
        }
    }
}