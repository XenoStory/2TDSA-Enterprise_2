using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI.Model
{
    class Professor : Pessoa, ITrabalhador
    {
        // Propriedade (get e set)
        public IList<string> Disciplinas { get; set; }

        // Construtor
        public Professor(string nome) : base(nome)
        {

        }

        public override void FazerProva()
        {
            Console.WriteLine("Professor desenvolvendo a prova.");
        }

        public void ReceberSalario()
        {
            Console.WriteLine("Recebendo o salário.");
        }
    }
}
