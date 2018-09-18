using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap06.Wev.MVC.Models
{
    public class Aposta
    {
        public int ApostaId { get; set; }
        public DateTime Data { get; set; }

        public IList<int> Sequencia { get; set;}

        public Concurso Concurso;
        public int Numero { get; set; }
    }
}