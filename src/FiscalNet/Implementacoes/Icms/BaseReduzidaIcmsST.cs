using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseReduzidaIcmsST
    {
        private decimal BaseIcmsProprio { get; set; }
        private decimal MVA { get; set; }
        private decimal ValorIPI { get; set; }
        private decimal PercentualReducaoST { get; set; }

        public BaseReduzidaIcmsST(decimal baseIcmsProprio, decimal mva, decimal percentualReducaoST, decimal valorIpi = 0)
        {
            this.BaseIcmsProprio = baseIcmsProprio;
            this.MVA = mva;
            this.ValorIPI = valorIpi;
            this.PercentualReducaoST = percentualReducaoST;
        }

        public decimal CalcularBaseReduzidaIcmsST()
        {
            decimal baseST = (BaseIcmsProprio) * (1 + (MVA / 100));

            baseST = baseST - (baseST * (PercentualReducaoST/100));

            decimal baseSTReduzida = baseST + ValorIPI;

            return decimal.Round(baseSTReduzida,2, MidpointRounding.ToEven);
        }
    }
}
