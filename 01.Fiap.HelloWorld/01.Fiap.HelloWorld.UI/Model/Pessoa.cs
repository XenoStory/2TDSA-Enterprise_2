using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    abstract class Pessoa
    {
        // Campo (Atributo)
        private string _nome;

        public int Idade { get; set; }
        public Genero Genero { get; set; }

        // Propriedades (gets e sets)
        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        // Construtores
        public Pessoa(string nome)
        {
            _nome = nome;
        }

        // Métodos
        // Virtual -> permite a sobrescrita de método
        public virtual void Estudar()
        {
            Console.WriteLine("Pessoa estudando");
        }
        public abstract void FazerProva();


    }
}
