using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class ValorIcmsProprio
    {
        private decimal BaseCalculo { get; set; }
        private decimal AliquotaIcmsProprio { get; set; }

        public ValorIcmsProprio(decimal baseCalculo, decimal aliqIcmsProprio)
        {
            this.BaseCalculo = baseCalculo;
            this.AliquotaIcmsProprio = aliqIcmsProprio;
        }

        public decimal CalcularValorIcmsProprio()
        {
            return decimal.Round((AliquotaIcmsProprio / 100 * BaseCalculo),2, MidpointRounding.ToEven);
        }
    }
}
