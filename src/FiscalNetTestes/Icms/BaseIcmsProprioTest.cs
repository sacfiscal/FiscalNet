using FiscalNet.Implementacoes.Icms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiscalNetTestes.Icms
{
    [TestClass]
    public class BaseIcmsProprioTest
    {
        [TestMethod]
        public void TestarBaseIcmsProprio()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 15.00M;

            BaseIcmsProprio baseIcmsProrio = new BaseIcmsProprio(valorProduto, valorFrete,
                valorSeguro, despesasAcessorias, valorDesconto, valorIpi);

            decimal vBC = baseIcmsProrio.CalcularBaseIcmsProprio();
            Assert.IsTrue(vBC.Equals(148.50M));
        }
    }
}