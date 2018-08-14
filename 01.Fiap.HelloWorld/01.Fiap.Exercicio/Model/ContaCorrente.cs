using Fiap.Banco.Model.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    // sealed: classe não pode ser herdada (mesmo que final no Java)
    sealed class ContaCorrente : Conta
    {
        public TipoConta TipoConta { get; set; }

        public override void Retirar(decimal valor)
        {
            if (TipoConta == TipoConta.Comum && valor > Saldo)
            {
                throw new Exception("Saldo não permitido devido ao saldo.");
            }

            Saldo -= valor;
        }
    }
}
