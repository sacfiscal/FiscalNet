using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseReduzidaIcmsProprio
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal PercentualReducao { get; set; }

        public BaseReduzidaIcmsProprio(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorDesconto,
            decimal percentualReducao,
            decimal valorIpi = 0)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi = valorIpi;
            this.ValorDesconto = valorDesconto;
            this.PercentualReducao = percentualReducao;
        }

        public decimal CalcularBaseReduzidaIcmsProprio()
        {
            decimal BaseIcms = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias -
                ValorDesconto);

            return decimal.Round((BaseIcms - (BaseIcms * (PercentualReducao / 100))) + ValorIpi, 2, MidpointRounding.ToEven);
        }
    }
}
