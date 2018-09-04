using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class CartaoReal
    {
        public int CartaoRealId { get; set; }
        public long Numero { get; set; }
        public int Cvv { get; set; }

        // Relacionamentos
        // 1 - N
        public IList<CartaoVirtual> CartoesVirtuais { get; set; }
    }
}