using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms900
    {
        decimal CalcularBaseIcmsProprio();
        decimal CalcularBaseReduzidaIcmsProprio();
        decimal ValorIcmsProprio();
        decimal ValorCreditoSN();
        decimal ValorIcmsProprioBaseReduzida();
        decimal CalcularBaseICMSST();
        decimal CalcularBaseReduzidaICMSST();
        decimal ValorICMSST();
        decimal ValorICMSSTBaseReduzida();
    }
}
