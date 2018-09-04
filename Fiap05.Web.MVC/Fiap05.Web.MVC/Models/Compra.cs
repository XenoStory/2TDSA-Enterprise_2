using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fiap05.Web.MVC.Models
{
    public class Compra
    {
        public int CompraId { get; set; }
        public DateTime Data { get; set; }

        // Relacionamentos
        // 1 - 1
        public CartaoVirtual CartaoVirtual { get; set; }
        // Map foreign key from CartaoVirtual
        public int CartaoVirtualId { get; set; }

        // N - N
        public IList<Produto> Produtos { get; set; }
    }
}