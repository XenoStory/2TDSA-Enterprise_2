using Fiap06.Wev.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Fiap06.Wev.MVC.Repositories
{
    public interface IConcursoRepository
    {
        IList<Concurso> Listar();
        void Cadastrar(Concurso c);
        void Atualizar(Concurso c);
        Concurso BuscarPorNumero(int n);
        void Excluir(int n);
        IList<Concurso> BuscarPor(Expression<Func<Concurso, bool>> filtro);
    }
}
