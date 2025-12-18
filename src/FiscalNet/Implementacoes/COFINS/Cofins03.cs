using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.COFINS
{
    public class Cofins03 : ICofins03
    {
        // A Base de COFINS será a Quantidade (qTrib) do produto na operação
        private decimal BaseCalculo { get; set; }
        // Valor por Unidade Tributável
        private decimal AliquotaPorUnidade { get; set; }

        public Cofins03(decimal baseCalculo, decimal aliquotaUnidade)
        {
            this.BaseCalculo = baseCalculo;
            this.AliquotaPorUnidade = aliquotaUnidade;
        }

        public decimal ValorCofins()
        {
            return decimal.Round((AliquotaPorUnidade * BaseCalculo), 2);
        }
    }
}
