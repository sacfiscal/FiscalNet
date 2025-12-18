using FiscalNet.Interfaces;
using System;

namespace FiscalNet.Implementacoes.IBSCBS
{
    public class Cbs : ICbs
    {
        public Cbs(decimal vBCCbs = 0, decimal pRedCbs = 0, decimal pDifCbs = 0, decimal pAliquotaCbs = 0, decimal devolucaoTributo = 0)
        {
            vBC = vBCCbs;
            pRed = pRedCbs;
            pDif = pDifCbs;
            pAliq = pAliquotaCbs;
            vDevTrib = devolucaoTributo;
        }

        private decimal vBC;
        private decimal pRed;
        private decimal pDif;
        private decimal pAliq;
        private decimal vDevTrib;
        public decimal AliquotaEfetiva()
        {
            decimal aliquotaEfetivaCbs = 0;
            if (pRed > 0)
                aliquotaEfetivaCbs = decimal.Round(pAliq * (1 - (pRed / 100)), 2, MidpointRounding.ToEven);
            else
                aliquotaEfetivaCbs = 0;

            return aliquotaEfetivaCbs;
        }

        public decimal Diferimento()
        {
            decimal valorDiferimento = decimal.Round((vBC * pDif / 100), 2, MidpointRounding.ToEven);
            return valorDiferimento;
        }

        public decimal ValorCbs()
        {
            //Base de Cálculo x Alíquota(vBC[tag: gIBSCBS / vBC] x pIBSMun) - vDif – vDevTrib
            decimal valorCbs = 0;
            if (pRed > 0)
                valorCbs = decimal.Round(((vBC * (AliquotaEfetiva() / 100)) - Diferimento() - vDevTrib), 2, MidpointRounding.ToEven);
            else
                valorCbs = decimal.Round(((vBC * (pAliq / 100)) - Diferimento() - vDevTrib), 2, MidpointRounding.ToEven);

            return valorCbs;
        }
    }
}
