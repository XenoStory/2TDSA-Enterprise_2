using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repositories
{
    public interface IFilmeRepository
    {
        void Atualizar(Filme f);
        List<Filme> Listar();
        List<Filme> BuscarPor(Expression<Func<Filme, bool>> filter);
        Filme BuscarPorId(int codigo);
        void Remover(int codigo);
        void Cadastrar(Filme f);

    }
}