using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.PIS
{
    public class BasePIS
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal ValorIcms { get; set;}

        public BasePIS(decimal valorProduto,
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

        public decimal CalcularBasePIS()
        {
            decimal basePIS = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias -
                ValorDesconto);

            basePIS = basePIS - ValorIcms;
            return decimal.Round(basePIS, 2, MidpointRounding.ToEven);
        }


    }
}
