using FiscalNet.Interfaces;
using System;

namespace FiscalNet.Implementacoes.IBSCBS
{
    public class IbsUf : IIbsUf
    {
        public IbsUf(decimal vBCIbsCbs = 0,  decimal pRedIbsUF = 0, decimal pDifIbsUF = 0, decimal pAliquotaIbsUF = 0, decimal devolucaoTributo = 0)
        {
            vBC = vBCIbsCbs;
            pRed = pRedIbsUF;
            pDif = pDifIbsUF;
            pAliq = pAliquotaIbsUF;
            vDevTrib = devolucaoTributo;
        }

        private decimal vBC;
        private decimal pRed;
        private decimal pDif;
        private decimal pAliq;
        private decimal vDevTrib;
        public decimal AliquotaEfetiva()
        {
            decimal aliquotaEfetivaIbsUf = 0;
            if (pRed > 0)
                aliquotaEfetivaIbsUf = decimal.Round(pAliq * (1 - (pRed / 100)), 2, MidpointRounding.ToEven);
            else
                aliquotaEfetivaIbsUf = 0;

            return aliquotaEfetivaIbsUf;
        }

        public decimal Diferimento()
        {
            decimal valorDiferimento = decimal.Round((vBC * pDif / 100), 2, MidpointRounding.ToEven);
            return valorDiferimento;
        }

        public decimal ValorIbsUf()
        {
            //Base de Cálculo x Alíquota(vBC[tag: gIBSCBS / vBC] x pIBSUF) - vDif – vDevTrib
            decimal valorIbsUf = 0;
            if (pRed > 0)
                valorIbsUf = decimal.Round(((vBC * (AliquotaEfetiva() / 100)) - Diferimento() - vDevTrib), 2, MidpointRounding.ToEven);
            else
                valorIbsUf = decimal.Round(((vBC * ( pAliq / 100)) - Diferimento() - vDevTrib), 2, MidpointRounding.ToEven);

            return valorIbsUf;
        }
    }
}
