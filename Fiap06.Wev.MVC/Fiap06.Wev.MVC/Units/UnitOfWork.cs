using Fiap06.Wev.MVC.Persistence;
using Fiap06.Wev.MVC.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Wev.MVC.Units
{
    public class UnitOfWork : IDisposable
    {
        private FiapSenaContext _c = new FiapSenaContext();

        private IConcursoRepository _concursoRepository;

        private IApostaRepository _apostaRepository;

        public IConcursoRepository ConcursoRepository
        {
            get
            {
                if (_concursoRepository == null)
                    _concursoRepository = new ConcursoRepository(_c);
                return _concursoRepository;
            }
        }

        public IApostaRepository ApostaRepository
        {
            get
            {
                if (_apostaRepository == null)
                    _apostaRepository = new ApostaRepository(_c);
                return _apostaRepository;
            }
        }

        public void Salvar()
        {
            _c.SaveChanges();
        }
        // Clean resources
        public void Dispose()
        {
            if(_c != null)
                _c.Dispose();

            GC.SuppressFinalize(this);
        }
    }
}