using Fiap07.Web.MVC.Persistence;
using Fiap07.Web.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapPlayContext _c = new FiapPlayContext();

        private IFilmeRepository _filmeRepository;

        private ICategoriaRepository _categoriaRepository;

        public IFilmeRepository FilmeRepository
        {
           get
           {
                if (_filmeRepository == null)
                    _filmeRepository = new FilmeRepository(_c);
                return _filmeRepository;
           }
        }

        public ICategoriaRepository CategoriaRepository
        {
            get
            {
                if (_categoriaRepository == null)
                    _categoriaRepository = new CategoriaRepository(_c);

                return _categoriaRepository;
            }
        }

        public void Dispose()
        {
            if(_c != null)
                _c.Dispose();

            GC.SuppressFinalize(this);
        }

        public void Salvar()
        {
            _c.SaveChanges();
        }
    }
}