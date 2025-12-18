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
    public class Icms10Test
    {
        [TestMethod]
        public void TestarIcms10()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 4.74M;
            decimal valorSeguro = 1.89M;
            decimal despesasAcessorias = 0.95M;
            decimal valorDesconto = 2.370M;
            decimal valorIpi = 15.00M;
            decimal aliquotaIcmsProprio = 12.00M;
            decimal aliquotaIcmsST = 18.00M;
            decimal mva = 40.65M;
            decimal percentualReducaoST = 10;

            Icms10 icms10 = new Icms10(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorIpi, valorDesconto, aliquotaIcmsProprio, aliquotaIcmsST, mva, percentualReducaoST);

            decimal vBC = icms10.BaseIcmsProprio();

            decimal vICMS = icms10.ValorIcmsProprio();

            decimal vBCST = icms10.BaseIcmsST();

            decimal vICMSST = icms10.ValorIcmsST();

            decimal vICMSSTDeson = icms10.ValorICMSSTDesonerado();

            Assert.IsTrue(vBC.Equals(140.21M));
            Assert.IsTrue(vICMS.Equals(16.83M));
            Assert.IsTrue(vBCST.Equals(192.48M));
            Assert.IsTrue(vICMSST.Equals(17.82M));
        }

    }
}
