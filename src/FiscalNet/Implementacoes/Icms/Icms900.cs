using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms900 : IIcms900
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliquotaIcmsProprio { get; set; }
        private decimal PercentualReducao { get; set; }
        private decimal PercentualCreditoSN { get; set; }
        private decimal AliquotaIcmsST { get; set; }
        private decimal Mva { get; set; }
        private decimal PercentualReducaoST { get; set; }
        private BaseIcmsProprio BaseIcmsProprio { get; set; }
        private BaseReduzidaIcmsProprio BCReduzidaIcmsProprio { get; set; }
        private BaseIcmsST BCIcmsST { get; set; }
        private BaseReduzidaIcmsST BCReduzidaIcmsST { get; set; }

        public Icms900(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal aliqIcmsST,
            decimal mva,
            decimal percentualCreditoSN = 0,
            decimal valorIpi = 0,
            decimal percentualReducao = 0,
            decimal percentualReducaoST = 0)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorDesconto = valorDesconto;
            this.AliquotaIcmsProprio = aliqIcmsProprio;
            this.AliquotaIcmsST = aliqIcmsST;
            this.Mva = mva;
            this.PercentualCreditoSN = percentualCreditoSN;
            this.ValorIpi = valorIpi;
            this.PercentualReducao = percentualReducao;
            this.PercentualReducaoST = percentualReducaoST;
        }

        #region ICMS Próprio
        public decimal CalcularBaseIcmsProprio()
        {
            this.BaseIcmsProprio = new BaseIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto, ValorIpi);

            return BaseIcmsProprio.CalcularBaseIcmsProprio();
        }

        public decimal CalcularBaseReduzidaIcmsProprio()
        {
            this.BCReduzidaIcmsProprio = new BaseReduzidaIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto, PercentualReducao, ValorIpi);

            return BCReduzidaIcmsProprio.CalcularBaseReduzidaIcmsProprio();
        }

        public decimal ValorIcmsProprio()
        {
            decimal valorIcmsProprio = new ValorIcmsProprio(CalcularBaseIcmsProprio(), AliquotaIcmsProprio)
                .CalcularValorIcmsProprio();

            return decimal.Round(valorIcmsProprio, 2);
        }

        public decimal ValorIcmsProprioBaseReduzida()
        {
            decimal valorIcmsProprio = new ValorIcmsProprio(CalcularBaseReduzidaIcmsProprio(), AliquotaIcmsProprio)
                .CalcularValorIcmsProprio();

            return decimal.Round(valorIcmsProprio, 2);
        }

        public decimal ValorCreditoSN()
        {
            decimal valorCreditoSN = 0;

            if (PercentualReducao == 0)
                valorCreditoSN = (CalcularBaseIcmsProprio() * (PercentualCreditoSN / 100));
            else
                valorCreditoSN = (CalcularBaseReduzidaIcmsProprio() * (PercentualCreditoSN / 100));

            return decimal.Round(valorCreditoSN, 2, MidpointRounding.ToEven);
        }
        #endregion

        #region ICMS ST
        public decimal CalcularBaseICMSST()
        {
            this.BCIcmsST = new BaseIcmsST(CalcularBaseIcmsProprio(), Mva, ValorIpi);
            return BCIcmsST.CalcularBaseIcmsST();
        }

        public decimal CalcularBaseReduzidaICMSST()
        {
            this.BCReduzidaIcmsST = new BaseReduzidaIcmsST(CalcularBaseIcmsProprio(), Mva,
                                                            PercentualReducaoST, ValorIpi);
            return BCReduzidaIcmsST.CalcularBaseReduzidaIcmsST();
        }

        public decimal ValorICMSST()
        {
            return new ValorIcmsST(CalcularBaseICMSST(), AliquotaIcmsST, ValorIcmsProprio()).CalcularValorIcmsST();
        }

        public decimal ValorICMSSTBaseReduzida()
        {
            return new ValorIcmsST(CalcularBaseReduzidaICMSST(), AliquotaIcmsST, ValorIcmsProprio()).CalcularValorIcmsST();
        }
        #endregion
    }
}
