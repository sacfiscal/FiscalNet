using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.COFINS
{
    public class BaseCofins
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal ValorIcms { get; set;}

        public BaseCofins(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorDesconto,
            decimal valorIcms = 0)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorDesconto = valorDesconto;
            this.ValorIcms = valorIcms;
        }

        public decimal CalcularBaseCofins()
        {
            decimal baseCofins = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias -
                ValorDesconto);

            baseCofins = baseCofins - ValorIcms;

            return decimal.Round(baseCofins, 2);
        }
    }
}
