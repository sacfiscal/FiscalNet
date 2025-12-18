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
    public class BaseIcmsSTTest
    {
        [TestMethod]
        public void TestarBaseICMSST()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 0;
            decimal mva = 40.65M;

            BaseIcmsProprio baseIcmsProprio = new BaseIcmsProprio(valorProduto, valorFrete,
                valorSeguro, despesasAcessorias, valorDesconto);

            decimal vBC = baseIcmsProprio.CalcularBaseIcmsProprio();

            BaseIcmsST baseIcmsST = new BaseIcmsST(vBC, mva, valorIpi);

            decimal vBCST = baseIcmsST.CalcularBaseIcmsST();

            Assert.IsTrue(vBC.Equals(133.50M));
            Assert.IsTrue(vBCST.Equals(187.77M));
        }
    }
}
