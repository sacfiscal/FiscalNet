using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms51
    {
        decimal BaseIcmsProprio();
        decimal ValorIcmsOperacao();
        decimal ValorIcmsDiferido();
        decimal ValorIcmsProprio();

    }
}
