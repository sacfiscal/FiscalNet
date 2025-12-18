using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Interfaces
{
    public interface IIpi50AdValorem
    {
        decimal CalcularBaseIPI();
        decimal ValorIPI();
    }
}
