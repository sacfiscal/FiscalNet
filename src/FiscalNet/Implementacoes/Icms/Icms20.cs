using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms20 : IIcms20
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliquotaIcmsProprio { get; set; }
        private decimal PercentualReducao { get; set; }
        private BaseReduzidaIcmsProprio BaseReduzidaIcms { get; set; }

        public Icms20(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliquotaIcmsProprio,
            decimal percentualReducao)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi = valorIpi;
            this.ValorDesconto = valorDesconto;
            this.AliquotaIcmsProprio = aliquotaIcmsProprio;
            this.PercentualReducao = percentualReducao;
            this.BaseReduzidaIcms = new BaseReduzidaIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto, PercentualReducao, ValorIpi);
        }

        public decimal BaseReduzidaIcmsProprio()
        {
            return BaseReduzidaIcms.CalcularBaseReduzidaIcmsProprio();
        }

        public decimal ValorIcmsProprio()
        {
            decimal baseReduzidaIcms = BaseReduzidaIcmsProprio();
            decimal valorIcms = baseReduzidaIcms * (AliquotaIcmsProprio / 100);
            return decimal.Round(valorIcms,2);
        }

        public decimal ValorIcmsDesonerado()
        {
            Icms00 icms00 = new Icms00(ValorProduto, ValorFrete, ValorSeguro,
                                            DespesasAcessorias, ValorIpi, ValorDesconto, AliquotaIcmsProprio);
            
            decimal valorIcmsNormal = icms00.ValorIcmsProprio();

            decimal valorIcmsDesonerado = valorIcmsNormal - ValorIcmsProprio();

            return decimal.Round(valorIcmsDesonerado,2, MidpointRounding.ToEven);
        }
    }
}
