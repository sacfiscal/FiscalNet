using FiscalNet.Implementacoes.Icms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.Icms
{
    [TestClass]
    public class BaseReduzidaIcmsSTTest
    {
        [TestMethod]
        public void TestarBaseReduzidaIcmsST()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 0.75M;
            decimal despesasAcessorias = 2.25M;
            decimal valorDesconto = 15.00M;
            decimal valorIpi = 0;
            decimal mva = 40.65M;
            decimal percentualReducaoST = 10.00M;

            BaseIcmsProprio baseIcmsProprio = new BaseIcmsProprio(valorProduto, valorFrete,
                valorSeguro, despesasAcessorias, valorDesconto);

            decimal vBC = baseIcmsProprio.CalcularBaseIcmsProprio();

            BaseReduzidaIcmsST baseIcmsST = new BaseReduzidaIcmsST(vBC, mva, percentualReducaoST, valorIpi);

            decimal vBCST = baseIcmsST.CalcularBaseReduzidaIcmsST();

            Assert.IsTrue(vBC.Equals(130.50M));
            Assert.IsTrue(vBCST.Equals(165.19M));
        }
    }
}
