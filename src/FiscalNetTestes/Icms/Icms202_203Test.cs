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
    public class Icms202_203Test
    {
        [TestMethod]
        public void TestarIcms202_203()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            decimal valorDesconto = 9.92M;
            decimal aliquotaIcmsProprio = 18.00M;
            decimal aliquotaIcmsST = 18.00M;
            decimal mva = 38.00M;
            decimal percentualReducao = 0M;
            decimal percentualReducaoST = 0M;

            Icms202_203 icms202_203 = new Icms202_203(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorDesconto, aliquotaIcmsProprio, aliquotaIcmsST, mva,
                percentualReducao, percentualReducaoST);

            decimal vBC = icms202_203.CalcularBaseIcmsProprio();

            decimal vICMS = icms202_203.ValorIcmsProprio();

            decimal vBCST = icms202_203.BaseIcmsST();

            decimal vICMSST = icms202_203.ValorIcmsST();

            Assert.IsTrue(vBC.Equals(177.03M));
            Assert.IsTrue(vICMS.Equals(31.87M));
            Assert.IsTrue(vBCST.Equals(244.30M));
            Assert.IsTrue(vICMSST.Equals(12.10M));
        }
    }
}
