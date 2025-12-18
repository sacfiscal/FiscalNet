using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms10
    {
        decimal BaseIcmsProprio();
        decimal ValorIcmsProprio();
        decimal BaseIcmsST();
        decimal ValorIcmsST();
        decimal ValorICMSSTDesonerado();
    }
}
