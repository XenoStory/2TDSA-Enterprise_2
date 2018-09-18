using Fiap06.Wev.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Web;

namespace Fiap06.Wev.MVC.Repositories
{
    public interface IApostaRepository
    {
        IList<Aposta> Listar();
        void Cadastrar(Aposta p);
        void Atualizar(Aposta p);
        Aposta BuscarPorNumero(int n);
        void Excluir(int n);
        IList<Aposta> BuscarPor(Expression<Func<Aposta, bool>> filtro);

    }
}