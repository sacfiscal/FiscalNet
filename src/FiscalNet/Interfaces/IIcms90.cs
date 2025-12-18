using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms90
    {
        decimal CalcularBaseIcmsProprio();
        decimal CalcularBaseReduzidaIcmsProprio();
        decimal ValorIcmsProprio();
        decimal ValorIcmsProprioBaseReduzida();
        decimal ValorIcmsProprioDesonerado();
        decimal CalcularBaseICMSST();
        decimal CalcularBaseReduzidaICMSST();
        decimal ValorICMSST();
        decimal ValorICMSSTBaseReduzida();
        decimal ValorICMSSTDesonerado();

    }
}
