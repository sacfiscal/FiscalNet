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
    public class Icms00Test
    {
        [TestMethod]
        public void TestarIcms00()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 15.00M;
            decimal aliquotaIcmsProprio = 18.00M;          

            Icms00 icms00 = new Icms00(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorIpi, valorDesconto, aliquotaIcmsProprio);

            decimal vBC = icms00.BaseIcmsProprio();

            decimal vICMS = icms00.ValorIcmsProprio();

            Assert.IsTrue(vBC.Equals(148.50M));
            Assert.IsTrue(vICMS.Equals(26.73M));

        }
    }
}
