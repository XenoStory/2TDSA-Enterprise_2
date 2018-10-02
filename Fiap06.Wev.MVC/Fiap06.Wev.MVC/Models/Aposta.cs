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

        public IList<int> _sequencia;

        public IList<int> Sequencia
        {
            get { return _sequencia; }
            set
            {
                _sequencia = value;
                // Same as PHP explode
                _sequenciaString = string.Join(",", Sequencia.ToArray());
            }
        }

        private string _sequenciaString;

        public string SequenciaString
        {
            set
            {
                _sequenciaString = value;
                // Same as PHP implode
                _sequencia = _sequenciaString.Split(',').Select(Int32.Parse).ToList();
            } get { return _sequenciaString; }
        }

        public Concurso Concurso { get; set; }
        public int Numero { get; set; }
    }
}