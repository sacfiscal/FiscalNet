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
    public class Icms20Test
    {
        [TestMethod]
        public void TestarIcms20()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 0;
            decimal aliquotaIcmsProprio = 18.00M;
            decimal percentualReducao = 10.00M;

            Icms20 icms20 = new Icms20(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorIpi, valorDesconto, aliquotaIcmsProprio, percentualReducao);

            decimal vBC = icms20.BaseReduzidaIcmsProprio();

            decimal vICMS = icms20.ValorIcmsProprio();

            decimal vICMSDeson = icms20.ValorIcmsDesonerado();

            Assert.IsTrue(vBC.Equals(120.15M));
            Assert.IsTrue(vICMS.Equals(21.63M));
            Assert.IsTrue(vICMSDeson.Equals(2.40M));
        }
    }
}
