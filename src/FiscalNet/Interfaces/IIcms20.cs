using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms20
    {
        decimal BaseReduzidaIcmsProprio();
        decimal ValorIcmsProprio();
        decimal ValorIcmsDesonerado();
    }
}
