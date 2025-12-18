using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class FCPEfetivo : IFcpEfet
    {
        // vFCP = valor do FCP normal do item, e vFCPDIF = valof diferido do ICMS relativo ao FCP (vFCPDif)
        private decimal ValorFCP { get; set; }
        private decimal ValorFCPDiferido { get; set; }
        public FCPEfetivo(decimal valorFCP, decimal valorFCPDiferido)
        {
            this.ValorFCP = valorFCP;
            this.ValorFCPDiferido = valorFCPDiferido;
        }
        public decimal ValorFcpEfetivo()
        {
            return decimal.Round((ValorFCP - ValorFCPDiferido), 2, MidpointRounding.ToEven);
        }
    }
}
