using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class CartaoVirtual
    {
        public int CartaoVirtualId { get; set; }
        public long Numero { get; set; }
        public bool Utilizado { get; set; }

        // Relacionamentos
        // 1 - N
        public CartaoReal CartaoReal { get; set; }
        public int CartaoRealId { get; set; }
    }
}