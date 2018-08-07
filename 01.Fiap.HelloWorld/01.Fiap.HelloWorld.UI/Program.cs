using _01.Fiap.HelloWorld.UI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.HelloWorld.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno("Maria", 555);
            aluno.Nome = "Maria"; // set
            Console.WriteLine(aluno.Nome);

            // Instanciar o professor
            Professor prof = new Professor("Pedro Gonzales")
            {
                Idade = 30
            };
        }
    }
}
