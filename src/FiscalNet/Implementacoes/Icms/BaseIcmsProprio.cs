using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class BaseIcmsProprio
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }

        public BaseIcmsProprio(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,            
            decimal valorDesconto,
            decimal valorIpi = 0)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi = valorIpi;
            this.ValorDesconto = valorDesconto;
        }

        public decimal CalcularBaseIcmsProprio()
        {
            decimal BaseIcmsProprio = (ValorProduto +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias +
                ValorIpi -
                ValorDesconto);
            return decimal.Round(BaseIcmsProprio, 2, MidpointRounding.ToEven);
        }
    }
}
