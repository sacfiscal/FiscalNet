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
    public class Icms201Test
    {
        [TestMethod]
        public void TestarIcms201()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            decimal valorDesconto = 9.92M;
            decimal aliquotaIcmsProprio = 18.00M;
            decimal aliquotaIcmsST = 18.00M;
            decimal mva = 38.00M;
            decimal percentualCreditoSN = 1.25M;
            decimal percentualReducao = 0M;
            decimal percentualReducaoST = 0M;

            Icms201 icms201 = new Icms201(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorDesconto, aliquotaIcmsProprio, aliquotaIcmsST, mva, percentualCreditoSN,
                percentualReducao, percentualReducaoST);

            decimal vBC = icms201.CalcularBaseIcmsProprio();

            decimal vICMS = icms201.ValorIcmsProprio();

            decimal vCredSN = icms201.ValorCreditoSN();

            decimal vBCST = icms201.BaseIcmsST();

            decimal vICMSST = icms201.ValorIcmsST();

            Assert.IsTrue(vBC.Equals(177.03M));
            Assert.IsTrue(vICMS.Equals(31.87M));
            Assert.IsTrue(vCredSN.Equals(2.21M));
            Assert.IsTrue(vBCST.Equals(244.30M));
            Assert.IsTrue(vICMSST.Equals(12.10M));
        }
    }
}
