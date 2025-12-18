using FiscalNet.Interfaces;
using System;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms30 : IIcms30
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqIcmsProprio { get; set; }
        private decimal AliqIcmsST { get; set; }
        private decimal Mva { get; set; }
        private decimal PercentualReducaoST { get; set; }

        private BaseIcmsProprio BCIcmsProprio { get; set; }
        private BaseIcmsST BCIcmsST { get; set; }
        private BaseReduzidaIcmsST BCReduzidaIcmsST { get; set; }

        public Icms30(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal aliqIcmsST,
            decimal mva,
            decimal percentualReducao = 0)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi = valorIpi;
            this.ValorDesconto = valorDesconto;
            this.AliqIcmsProprio = aliqIcmsProprio;
            this.AliqIcmsST = aliqIcmsST;
            this.Mva = mva;
            this.PercentualReducaoST = percentualReducao;

            this.BCIcmsProprio = new BaseIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto);
        }

        #region ICMS Próprio
        public decimal BaseIcmsProprio()
        {
            return BCIcmsProprio.CalcularBaseIcmsProprio();
        }

        public decimal ValorIcmsProprio()
        {
            decimal valorIcmsProprio = new ValorIcmsProprio(BaseIcmsProprio(), AliqIcmsProprio).CalcularValorIcmsProprio();
            return valorIcmsProprio;
        }
        public decimal ValorIcmsDesonerado()
        {
            return ValorIcmsProprio();
        }
        #endregion

        #region ICMSST
        public decimal BaseIcmsST()
        {
            if (PercentualReducaoST == 0)
            {
                this.BCIcmsST = new BaseIcmsST(BaseIcmsProprio(), Mva, ValorIpi);
                return BCIcmsST.CalcularBaseIcmsST();
            }
            else
            {
                this.BCReduzidaIcmsST = new BaseReduzidaIcmsST(BaseIcmsProprio(), Mva,
                                                        PercentualReducaoST, ValorIpi);
                return BCReduzidaIcmsST.CalcularBaseReduzidaIcmsST();
            }
        }        

        public decimal ValorIcmsST()
        {
            return new ValorIcmsST(BaseIcmsST(), AliqIcmsST, ValorIcmsProprio()).CalcularValorIcmsST();
        }
        #endregion
    }
}
