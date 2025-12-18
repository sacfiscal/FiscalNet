using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIbsMun
    {
        decimal AliquotaEfetiva();
        decimal Diferimento();
        decimal ValorIbsMun();
    }
}
