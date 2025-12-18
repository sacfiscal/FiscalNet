using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIcms70
    {
        decimal BaseIcmsProprio();
        decimal ValorIcmsProprio();
        decimal ValorIcmsProprioDesonerado();
        decimal BaseIcmsST();
        decimal ValorIcmsST();
        decimal ValorICMSSTDesonerado();
    }
}
