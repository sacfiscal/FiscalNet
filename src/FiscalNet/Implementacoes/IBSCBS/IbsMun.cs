using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.IBSCBS
{
    public class IbsMun : IIbsMun
    {
        public IbsMun(decimal vBCIbsCbs = 0, decimal pRedIbsMun = 0, decimal pDifIbsMun = 0, decimal pAliquotaIbsMun = 0, decimal devolucaoTributo = 0)
        {
            vBC = vBCIbsCbs;
            pRed = pRedIbsMun;
            pDif = pDifIbsMun;
            pAliq = pAliquotaIbsMun;
            vDevTrib = devolucaoTributo;
        }

        private decimal vBC;
        private decimal pRed;
        private decimal pDif;
        private decimal pAliq;
        private decimal vDevTrib;
        public decimal AliquotaEfetiva()
        {
            decimal aliquotaEfetivaIbsMun = 0;
            if (pRed > 0)
                aliquotaEfetivaIbsMun = decimal.Round(pAliq * (1 - (pRed / 100)), 2, MidpointRounding.ToEven);
            else
                aliquotaEfetivaIbsMun = 0;

            return aliquotaEfetivaIbsMun;
        }

        public decimal Diferimento()
        {
            decimal valorDiferimento = decimal.Round((vBC * pDif / 100), 2, MidpointRounding.ToEven);
            return valorDiferimento;
        }

        public decimal ValorIbsMun()
        {
            //Base de Cálculo x Alíquota(vBC[tag: gIBSCBS / vBC] x pIBSMun) - vDif – vDevTrib
            decimal valorIbsMun = 0;
            if (pRed > 0)
                valorIbsMun = decimal.Round(((vBC * (AliquotaEfetiva() / 100)) - Diferimento() - vDevTrib), 2, MidpointRounding.ToEven);
            else
                valorIbsMun = decimal.Round(((vBC * (pAliq / 100)) - Diferimento() - vDevTrib), 2, MidpointRounding.ToEven);

            return valorIbsMun;
        }
    }
}
