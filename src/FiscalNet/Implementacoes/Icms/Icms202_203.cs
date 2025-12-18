using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms202_203 : IIcms202_203
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliquotaIcmsProprio { get; set; }
        private decimal PercentualReducao { get; set; }
        private decimal AliquotaIcmsST { get; set; }
        private decimal Mva { get; set; }
        private decimal PercentualReducaoST { get; set; }
        private BaseIcmsProprio BaseIcmsProprio { get; set; }
        private BaseReduzidaIcmsProprio BCReduzidaIcmsProprio { get; set; }
        private BaseIcmsST BCIcmsST { get; set; }
        private BaseReduzidaIcmsST BCReduzidaIcmsST { get; set; }

        public Icms202_203(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal aliqIcmsST,
            decimal mva,
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
            this.PercentualReducao = percentualReducao;
            this.PercentualReducaoST = percentualReducaoST;
        }

        #region ICMS Próprio
        public decimal CalcularBaseIcmsProprio()
        {
            if (PercentualReducao == 0)
            {
                this.BaseIcmsProprio = new BaseIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto);

                return BaseIcmsProprio.CalcularBaseIcmsProprio();
            }
            else
            {
                this.BCReduzidaIcmsProprio = new BaseReduzidaIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto, PercentualReducao);

                return BCReduzidaIcmsProprio.CalcularBaseReduzidaIcmsProprio();
            }
        }

        public decimal ValorIcmsProprio()
        {
            return new ValorIcmsProprio(CalcularBaseIcmsProprio(), AliquotaIcmsProprio).CalcularValorIcmsProprio();
        }
        #endregion

        #region ICMSST
        public decimal BaseIcmsST()
        {
            if (PercentualReducaoST == 0)
            {
                this.BCIcmsST = new BaseIcmsST(CalcularBaseIcmsProprio(), Mva);
                return BCIcmsST.CalcularBaseIcmsST();
            }
            else
            {
                this.BCReduzidaIcmsST = new BaseReduzidaIcmsST(CalcularBaseIcmsProprio(), Mva,
                                                                PercentualReducaoST);
                return BCReduzidaIcmsST.CalcularBaseReduzidaIcmsST();
            }
        }

        public decimal ValorIcmsST()
        {
            return new ValorIcmsST(BaseIcmsST(), AliquotaIcmsST, ValorIcmsProprio()).CalcularValorIcmsST();
        }
        #endregion   
    }
}
