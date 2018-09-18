using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Fiap06.Wev.MVC.Models
{
    public class Concurso
    {
        [Key]
        public int Numero { get; set; }
        public DateTime Data { get; set; }
        public float Premio { get; set; }
        public bool Acumulado { get; set; }

        public IList<Aposta> apostas { get; set; }

        public int ApostaId { get; set; }
    }
}