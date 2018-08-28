using Fiap04.Web.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Fiap04.Web.Mvc.Persistence
{
    public class ImigracaoContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
    }
}