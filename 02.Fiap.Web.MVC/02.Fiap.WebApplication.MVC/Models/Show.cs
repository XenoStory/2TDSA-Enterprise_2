using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _02.Fiap.WebApplication.MVC.Models
{
    public class Show
    {
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public string Banda { get; set; }
        public bool Estudante { get; set; }
    }
}