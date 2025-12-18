using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms201
    {
        decimal CalcularBaseIcmsProprio();
        decimal ValorIcmsProprio();
        decimal ValorCreditoSN();
        decimal BaseIcmsST();
        decimal ValorIcmsST();
    }
}
