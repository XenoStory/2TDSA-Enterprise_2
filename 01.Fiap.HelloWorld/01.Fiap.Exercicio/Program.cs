using Fiap.Banco.Model;
using Fiap.Banco.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fiap.Exercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            var cc = new ContaCorrente()
            {
                Agencia = 1,
                DataAbertura = DateTime.Now,
                Numero = 2,
                Saldo = 1000,
                TipoConta = TipoConta.Comum
            };

            var cp = new ContaPoupanca(0.5m)
            {
                Agencia = 1,
                Numero = 3,
                Saldo = 500,
                DataAbertura = new DateTime(2018, 1, 1),
                Taxa = 10
            };
            try
            {
                cc.Retirar(2000);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.WriteLine(cp.Rendimento);
            Console.ReadLine();
        }
    }
}
