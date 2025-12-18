using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class FcpDiferido : IFcpDif
    {
        // vFCP = valor do FCP normal do item, e pFCPDIF = percentual do diferimento de ICMS FCP
        private decimal ValorFCP { get; set; }
        private decimal AliquotaDiferimentoFCP { get; set; }

        public FcpDiferido(decimal valorFCP, decimal aliquotaDiferimentoFCP)
        {
            this.ValorFCP = valorFCP;
            this.AliquotaDiferimentoFCP = aliquotaDiferimentoFCP;
        }

        public decimal ValorFCPDiferido()
        {
            return decimal.Round((ValorFCP * AliquotaDiferimentoFCP / 100), 2, MidpointRounding.ToEven);
        }
    }
}
