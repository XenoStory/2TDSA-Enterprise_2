using Fiap.Banco.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }

        public override void Retirar(decimal valor)
        {
            if (TipoConta == TipoConta.Comum && Saldo - valor < 0)
            {
                throw new Exception("Saldo não permitido devido ao saldo.");
            }

            Saldo -= valor;
        }
    }
}
