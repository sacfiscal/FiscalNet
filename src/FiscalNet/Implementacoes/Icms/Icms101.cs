using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms101 : IIcms101
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorDesconto { get; set; }        
        private BaseIcmsProprio BaseIcmsProprio { get; set; }
        private decimal PercentualReducao { get; set; }        
        private BaseReduzidaIcmsProprio BaseReduzida { get; set; }
        private decimal PercentualCreditoSN { get; set; }

        public Icms101(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorDesconto,
            decimal percentualCreditoSN,
            decimal percentualReducao = 0)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorDesconto = valorDesconto;
            this.PercentualCreditoSN = percentualCreditoSN;
            this.PercentualReducao = percentualReducao;            
        }

        public decimal CalcularBaseIcmsProprio()
        {
            if(PercentualReducao == 0)
            {
                this.BaseIcmsProprio = new BaseIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto);

                return BaseIcmsProprio.CalcularBaseIcmsProprio();
            }
            else
            {
                this.BaseReduzida = new BaseReduzidaIcmsProprio(ValorProduto, ValorFrete, ValorSeguro,
                DespesasAcessorias, ValorDesconto, PercentualReducao);

                return BaseReduzida.CalcularBaseReduzidaIcmsProprio();
            }               
        }

        public decimal ValorCreditoSN()
        {
            decimal valorCreditoSN = (CalcularBaseIcmsProprio() * (PercentualCreditoSN / 100));

            return decimal.Round(valorCreditoSN,2, MidpointRounding.ToEven);
        }
    }
}
