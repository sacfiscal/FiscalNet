using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms30
    {
        decimal BaseIcmsProprio();
        decimal ValorIcmsProprio();
        decimal BaseIcmsST();
        decimal ValorIcmsST();
        decimal ValorIcmsDesonerado();
    }
}
