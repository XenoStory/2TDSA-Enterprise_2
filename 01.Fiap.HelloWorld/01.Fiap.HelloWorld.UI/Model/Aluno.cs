using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Aluno : Pessoa
    {
        // Propriedades
        public int Rm { get; set; }
        public decimal Mensalidade { get; set; }

        public Aluno(string nome, int rm) : base (nome)
        {
            Rm = rm;
        }

        // Sobreescrita do método abstract da classe pai
        public override void FazerProva()
        {
            Console.WriteLine("Aluno respondendo a prova.");
        }
        
        public override void Estudar()
        {
            Console.WriteLine("Aluno estudando muito para prova.");
        }
    }
}
