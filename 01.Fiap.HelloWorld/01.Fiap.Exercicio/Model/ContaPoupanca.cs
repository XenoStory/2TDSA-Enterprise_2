using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.Banco.Model
{
    class ContaPoupanca : Conta, IContaInvestimento
    {
        public decimal Taxa { get; set; }
        private readonly decimal _rendimento;

        public decimal Rendimento
        {
            get { return _rendimento; }
        }

        public ContaPoupanca(decimal rendimento)
        {
            _rendimento = rendimento;
        }

        public override void Retirar(decimal valor)
        {

            if(valor > Saldo)
            {
                throw new Exception("Saldo insuficiente para ação.");
            }

            Saldo -= Taxa + valor;
        }

        public decimal CalculaRetornoInvestimento()
        {
            return Saldo * Rendimento;
        }
    }
}
