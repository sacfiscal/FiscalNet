using FiscalNet.Implementacoes.IBSCBS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiscalNetTestes.IBSCBS
{
    [TestClass]
    public class BaseIbsCbsTest
    {
        [TestMethod]
        public void TestarBaseIbsCbs()
        {
            decimal valorProduto = 135.00M;
            decimal valorServico = 0;
            decimal valorFrete = 2.00M;
            decimal valorSeguro = 10.00M;
            decimal despesasAcessorias = 5.00M;
            decimal valorImpostoImportacao = 0;
            decimal valorDesconto = 10.00M;
            decimal valorPis = 8.85M;
            decimal valorCofins = 4.25M;
            decimal valorIcms = 25.56M;
            decimal valorIcmsUfDest = 0;
            decimal valorFcp = 2.84M;
            decimal valorFcpUfDest = 0;
            decimal valorIcmsMonofasico = 0;
            decimal valorIssqn = 0;
            decimal valorIS = 0;


            BaseIbsCbs baseIbsCbs = new BaseIbsCbs(valorProduto,
                valorServico,
                valorFrete,
                valorSeguro,
                despesasAcessorias,
                valorImpostoImportacao,
                valorDesconto,
                valorPis,
                valorCofins,
                valorIcms,
                valorIcmsUfDest,
                valorFcp,
                valorFcpUfDest,
                valorIcmsMonofasico,
                valorIssqn,
                valorIS);

            Assert.IsTrue(baseIbsCbs.CalcularBaseIbsCbs().Equals(100.50M));
        }
    }
}
