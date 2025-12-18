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
    public class Icms30Test
    {
        [TestMethod]
        public void TestarIcms30()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 15.00M;
            decimal aliquotaIcmsProprio = 12.00M;
            decimal aliquotaIcmsST = 18.00M;
            decimal mva = 40.65M;
            decimal percentualReducaoST = 10;

            Icms30 icms30 = new Icms30(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorIpi, valorDesconto, aliquotaIcmsProprio, aliquotaIcmsST, mva, percentualReducaoST);

            decimal vBCST = icms30.BaseIcmsST();

            decimal vICMSST = icms30.ValorIcmsST();

            decimal VICMSDeson = icms30.ValorIcmsDesonerado();

            Assert.IsTrue(vBCST.Equals(183.99M));
            Assert.IsTrue(vICMSST.Equals(17.10M));
            Assert.IsTrue(VICMSDeson.Equals(16.02M));
        }
    }
}
