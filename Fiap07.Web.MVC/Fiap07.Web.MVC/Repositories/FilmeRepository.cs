using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repositories
{
    public class FilmeRepository : IFilmeRepository
    {
        private FiapPlayContext _c;

        public FilmeRepository(FiapPlayContext c)
        {
            _c = c;
        }

        public void Atualizar(Filme f)
        {
            _c.Entry(f).State = System.Data.Entity.EntityState.Modified;
        }

        public List<Filme> BuscarPor(Expression<Func<Filme, bool>> filtro)
        {
            return _c.Filmes.Where(filtro).ToList();
        }

        public Filme BuscarPorId(int codigo)
        {
            return _c.Filmes.Find(codigo);
        }

        public void Cadastrar(Filme f)
        {
            _c.Filmes.Add(f);
        }

        public List<Filme> Listar()
        {
            return _c.Filmes.Include("Categoria").ToList();
        }

        public void Remover(int codigo)
        {
            var movie = BuscarPorId(codigo);
            _c.Filmes.Remove(movie);
        }
    }
}