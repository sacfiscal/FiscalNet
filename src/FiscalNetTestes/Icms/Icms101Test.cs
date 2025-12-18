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
    public class Icms101Test
    {
        [TestMethod]
        public void TestarIcms101()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 0.75M;
            decimal despesasAcessorias = 2.25M;
            decimal valorDesconto = 15.00M;
            decimal percentualCreditoSN = 1.25M;

            Icms101 icms101 = new Icms101(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorDesconto, percentualCreditoSN);

            decimal vBC = icms101.CalcularBaseIcmsProprio();

            // apenas este campo vai no XML junto com o pCredSN (percentualCreditoSN)
            decimal vCredSN = icms101.ValorCreditoSN();

            Assert.IsTrue(vBC.Equals(130.50M));
            Assert.IsTrue(vCredSN.Equals(1.63M));
        }
    }
}
