using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap07.Web.MVC.Models
{
    public class Filme
    {
        public int FilmeId { get; set; }

        public String Nome { get; set; }

        public int Duracao { get; set; }

        public Categoria Categoria { get; set; }

        public int ClassificacaoIndicativa { get; set; }
    }
}