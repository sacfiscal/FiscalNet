using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms202_203
    {
        decimal CalcularBaseIcmsProprio();
        decimal ValorIcmsProprio();
        decimal BaseIcmsST();
        decimal ValorIcmsST();
    }
}
