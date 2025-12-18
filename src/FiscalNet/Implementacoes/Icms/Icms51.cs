using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Icms51 : IIcms51
    {
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal ValorIpi { get; set; }
        private decimal ValorDesconto { get; set; }
        private decimal AliqIcmsProprio { get; set; }
        private decimal PercentualReducao { get; set; }
        private decimal PercentualDiferimento { get; set; }
        private BaseIcmsProprio BCIcmsProprio { get; set; }
        private BaseReduzidaIcmsProprio BCReduzidaIcmsProprio { get; set; }

        public Icms51(decimal valorProduto,
            decimal valorFrete,
            decimal valorSeguro,
            decimal despesasAcessorias,
            decimal valorIpi,
            decimal valorDesconto,
            decimal aliqIcmsProprio,
            decimal percentualReducao,
            decimal percentualDiferimento)
        {
            this.ValorProduto = valorProduto;
            this.ValorFrete = valorFrete;
            this.ValorSeguro = valorSeguro;
            this.DespesasAcessorias = despesasAcessorias;
            this.ValorIpi = valorIpi;
            this.ValorDesconto = valorDesconto;
            this.AliqIcmsProprio = aliqIcmsProprio;
            this.PercentualReducao = percentualReducao;
            this.PercentualDiferimento = percentualDiferimento;
            
        }

        public decimal BaseIcmsProprio()
        {
            if (PercentualReducao == 0)
            {
                this.BCIcmsProprio = new BaseIcmsProprio(ValorProduto, ValorFrete,
                                            ValorSeguro, DespesasAcessorias, ValorDesconto, ValorIpi);
                
                return BCIcmsProprio.CalcularBaseIcmsProprio();
            }
            else
            {
                this.BCReduzidaIcmsProprio = new BaseReduzidaIcmsProprio(ValorProduto, ValorFrete,
                                            ValorSeguro, DespesasAcessorias, ValorDesconto,
                                            PercentualReducao, ValorIpi);

                return BCReduzidaIcmsProprio.CalcularBaseReduzidaIcmsProprio();
            }
        }

        public decimal ValorIcmsOperacao()
        {
            return new ValorIcmsProprio(BaseIcmsProprio(), AliqIcmsProprio).CalcularValorIcmsProprio();
        }

        public decimal ValorIcmsDiferido()
        {
            decimal valorIcmsOperacao = ValorIcmsOperacao();
            decimal valorIcmsDiferido = (valorIcmsOperacao * (PercentualDiferimento / 100));
            
            return decimal.Round(valorIcmsDiferido,2, MidpointRounding.ToEven);
        }

        public decimal ValorIcmsProprio() 
        {
            decimal valorIcmsProprio = ValorIcmsOperacao() - ValorIcmsDiferido();
            
            return decimal.Round(valorIcmsProprio,2, MidpointRounding.ToEven);        
        }
    }
}
