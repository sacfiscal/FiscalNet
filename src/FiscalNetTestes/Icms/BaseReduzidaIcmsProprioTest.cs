using FiscalNet.Implementacoes.Icms;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiscalNetTestes.Icms
{
    [TestClass]
    public class BaseReduzidaIcmsProprioTest
    {
        [TestMethod]
        public void TestarBaseReduzidaIcmsProprio()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 0;
            decimal percentualReducao = 10.00M;


            BaseReduzidaIcmsProprio baseReduzidaIcmsProprio= new BaseReduzidaIcmsProprio(valorProduto, 
                valorFrete, valorSeguro, despesasAcessorias, valorDesconto, percentualReducao, valorIpi);

            decimal vBC = baseReduzidaIcmsProprio.CalcularBaseReduzidaIcmsProprio();
            Assert.IsTrue(vBC.Equals(120.15M));
        }
    }
}
