using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.IPI
{
    public class BaseIPI
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }

        public BaseIPI(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
        }

        public decimal CalcularBaseIPI()
        {
            decimal baseIpi = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias);
            return decimal.Round(baseIpi, 2, MidpointRounding.ToEven);
        }
    }
}
