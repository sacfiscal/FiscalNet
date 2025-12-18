using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.PIS
{
    public class Pis03 : IPis03
    {
        //  A Base de PIS será a Quantidade (qTrib) do produto na operação
        private decimal BaseCalculo { get; set; }
        // Valor por Unidade Tributável
        private decimal AliquotaPorUnidade { get; set; }

        public Pis03(decimal baseCalculo, decimal aliquotaUnidade)
        {
            this.BaseCalculo = baseCalculo;
            this.AliquotaPorUnidade = aliquotaUnidade;
        }

        public decimal ValorPis()
        {
            return decimal.Round((AliquotaPorUnidade * BaseCalculo), 2, MidpointRounding.ToEven);
        }
    }
}
