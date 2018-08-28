using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Fiap04.Web.Mvc.Models
{
    [Table("TPessoa")]
    public class Pessoa
    {
        [Column("id")]
        public int PessoaId { get; set; }
        [Required, MaxLength(40)]
        public string Nome { get; set; }
        [Required, Display(Name = "Data de Nascimento")]
        public DateTime DataNascimento { get; set; }
        [Required]  
        public int Dependentes { get; set; }

    }
}