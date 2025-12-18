using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class ValorIcmsST
    {
        private decimal BaseCalculoST { get; set; }
        private decimal AliquotaIcmsST { get; set; }
        private decimal ValorIcmsProprio { get; set; }

        public ValorIcmsST(decimal baseCalculoST, decimal aliqIcmsST, decimal valorIcmsProprio)
        {
            this.BaseCalculoST = baseCalculoST;
            this.AliquotaIcmsST = aliqIcmsST;
            this.ValorIcmsProprio = valorIcmsProprio;
        }

        public decimal CalcularValorIcmsST()
        {
            return decimal.Round(((BaseCalculoST * (AliquotaIcmsST / 100)) - ValorIcmsProprio),2, MidpointRounding.ToEven);
        }
    }
}
