using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms00 : IIcms00
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliquotaIcmsProprio { get; set; }
        private BaseIcmsProprio BaseIcms { get; set; }

        public Icms00(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliquotaIcmsProprio)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi = valorIpi;
            this.ValorDesconto = valorDesconto;
            this.AliquotaIcmsProprio = aliquotaIcmsProprio;
            this.BaseIcms = new BaseIcmsProprio(ValorProduto, ValorFrete, ValorSeguro, 
                DespesasAcessorias, ValorDesconto, ValorIpi);
        }

        public decimal BaseIcmsProprio()
        {
            return BaseIcms.CalcularBaseIcmsProprio();
        }

        public decimal ValorIcmsProprio()
        {
            return new ValorIcmsProprio(BaseIcmsProprio(), AliquotaIcmsProprio)
                .CalcularValorIcmsProprio();            
        }
    }
}
