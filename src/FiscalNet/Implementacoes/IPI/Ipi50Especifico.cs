using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNet.Implementacoes.IPI
{
    public class Ipi50Especifico : IIpiEspecifico
    {
        // A Base de IPI será a Quantidade (qTrib) do produto na operação
        private decimal BaseCalculo { get; set; }
        // Valor por Unidade Tributável
        private decimal AliquotaPorUnidade { get; set; }

        public Ipi50Especifico(decimal baseCalculo, decimal aliquotaUnidade)
        {
            this.BaseCalculo = baseCalculo;
            this.AliquotaPorUnidade = aliquotaUnidade;
        }

        public decimal ValorIPI()
        {
            return decimal.Round((AliquotaPorUnidade * BaseCalculo), 2, MidpointRounding.ToEven);
        }
    }
}
