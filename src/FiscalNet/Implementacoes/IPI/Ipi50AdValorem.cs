using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.IPI
{
    public class Ipi50AdValorem : IIpi50AdValorem
    {        
        private decimal ValorProduto { get; set; }
        private decimal ValorFrete { get; set; }
        private decimal ValorSeguro { get; set; }
        private decimal DespesasAcessorias { get; set; }
        private decimal AliquotaIPI { get; set; }
        private BaseIPI BaseCalculo { get; set; }

        public Ipi50AdValorem(decimal valorProduto, decimal valorFrete, decimal valorSeguro, 
            decimal despesasAcessorias, decimal aliquotaIPI)
        {
            ValorProduto = valorProduto;
            ValorFrete = valorFrete;
            ValorSeguro = valorSeguro;
            DespesasAcessorias = despesasAcessorias;
            AliquotaIPI = aliquotaIPI;
            this.BaseCalculo = new BaseIPI(ValorProduto, ValorFrete, ValorSeguro, DespesasAcessorias);
        }

        public decimal CalcularBaseIPI()
        {
            return decimal.Round(BaseCalculo.CalcularBaseIPI(),2, MidpointRounding.ToEven);
        }

        public decimal ValorIPI()
        {
            return decimal.Round((CalcularBaseIPI() * (AliquotaIPI/100)), 2, MidpointRounding.ToEven);
        }
    }
}
