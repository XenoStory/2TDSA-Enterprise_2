using Fiap07.Web.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap07.Web.MVC.Repositories
{
    public interface ICategoriaRepository
    {
        void Atualizar(Categoria c);
        List<Categoria> Listar();
        List<Categoria> BuscarPor(Expression<Func<Categoria, bool>> filter);
        Categoria BuscarPorId(int codigo);
        void Remover(int codigo);
        void Cadastrar(Categoria c);
    }
}