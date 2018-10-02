using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;
using Fiap07.Web.MVC.Models;
using Fiap07.Web.MVC.Persistence;

namespace Fiap07.Web.MVC.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private FiapPlayContext _c;

        public CategoriaRepository(FiapPlayContext c)
        {
            _c = c;
        }

        public void Atualizar(Categoria c)
        {
            _c.Entry(c).State = System.Data.Entity.EntityState.Modified;
        }

        public List<Categoria> BuscarPor(Expression<Func<Categoria, bool>> filter)
        {
            return _c.Categorias.Where(filter).ToList();
        }

        public Categoria BuscarPorId(int codigo)
        {
            return _c.Categorias.Find(codigo);
        }

        public void Cadastrar(Categoria c)
        {
            _c.Categorias.Add(c);
        }

        public List<Categoria> Listar()
        {
            return _c.Categorias.ToList();
        }

        public void Remover(int codigo)
        {
            var category = BuscarPorId(codigo);
            _c.Categorias.Remove(category);
        }
    }
}