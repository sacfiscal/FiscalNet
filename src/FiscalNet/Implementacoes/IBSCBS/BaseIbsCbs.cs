using System;

namespace FiscalNet.Implementacoes.IBSCBS
{
    public class BaseIbsCbs(decimal valorProduto,
        decimal valorServico = 0,
        decimal valorFrete = 0,
        decimal valorSeguro = 0,
        decimal despesasAcessorias = 0,
        decimal valorImpostoImportacao = 0,
        decimal valorDesconto = 0,
        decimal valorPis = 0,
        decimal valorCofins = 0,
        decimal valorIcms = 0,
        decimal valorIcmsUfDest = 0,
        decimal valorFcp = 0,
        decimal valorFcpUfDest = 0,
        decimal valorIcmsMonofasico = 0,
        decimal valorIssqn = 0,
        decimal valorIS = 0)
    {

        private decimal ValorProduto { get; set; } = valorProduto;
        private decimal ValorServico { get; set; } = valorServico;
        private decimal ValorFrete { get; set; } = valorFrete;
        private decimal ValorSeguro { get; set; } = valorSeguro;
        private decimal DespesasAcessorias { get; set; } = despesasAcessorias;
        private decimal ValorImpostoImportacao { get; set; } = valorImpostoImportacao;
        private decimal ValorDesconto { get; set; } = valorDesconto;
        private decimal ValorPis { get; set; } = valorPis;
        private decimal ValorCofins { get; set; } = valorCofins;
        private decimal ValorIcms { get; set; } = valorIcms;
        private decimal ValorIcmsUfDest { get; set; } = valorIcmsUfDest;
        private decimal ValorFcp { get; set; } = valorFcp;
        private decimal ValorFcpUfDest { get; set; } = valorFcpUfDest;
        private decimal ValorIcmsMonofasico { get; set; } = valorIcmsMonofasico;
        private decimal ValorIssqn { get; set; } = valorIssqn;
        private decimal ValorIS { get; set; } = valorIS;

        public decimal CalcularBaseIbsCbs()
        {
            decimal BaseIbsCbs = (ValorProduto +
                ValorServico +
                ValorFrete +
                ValorSeguro +
                DespesasAcessorias +
                ValorImpostoImportacao -
                ValorDesconto -
                ValorPis -
                ValorCofins -
                ValorIcmsUfDest -
                ValorFcp -
                ValorFcpUfDest -
                ValorIcmsMonofasico -
                ValorIcms -
                ValorIssqn +
                ValorIS);
            return decimal.Round(BaseIbsCbs, 2, MidpointRounding.ToEven);
        }
    }
}
