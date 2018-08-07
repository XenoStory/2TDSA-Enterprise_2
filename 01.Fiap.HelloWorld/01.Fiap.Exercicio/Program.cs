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
            ContaCorrente cc = new ContaCorrente();
            cc.Agencia = 5928;
            cc.DataAbertura = DateTime.Now;
            cc.Numero = 074771;
            cc.TipoConta = TipoConta.Comum;
            cc.Saldo = 101;
            cc.Retirar(100);
            Console.WriteLine(cc.Saldo);
            cc.Depositar(50);
            Console.WriteLine(cc.Saldo);

            ContaPoupanca cp = new ContaPoupanca(2);
            cp.Agencia = 5928;
            cp.DataAbertura = DateTime.Now;
            cp.Numero = 074771;
            cp.Saldo = 100;
            cp.Taxa = 5;
            cp.Retirar(100);
            Console.WriteLine(cp.Saldo);
            cp.Depositar(25);
            Console.WriteLine(cp.Saldo);

        }
    }
}
