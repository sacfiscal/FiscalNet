using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseIcmsST
    {
        // Para ICMS ST, o IPI não compõe a base de icms próprio
        private decimal BaseIcmsProprio { get; set; }
        private decimal MVA { get; set; }
        private decimal ValorIPI { get; set; }

        public BaseIcmsST(decimal baseIcms, decimal mva, decimal valorIpi = 0)
        {
            this.BaseIcmsProprio = baseIcms;
            this.MVA = mva;
            this.ValorIPI = valorIpi;
        }

        public decimal CalcularBaseIcmsST()
        {
            return decimal.Round((BaseIcmsProprio + ValorIPI) * (1 + (MVA / 100)),2, MidpointRounding.ToEven);
        }
    }
}
