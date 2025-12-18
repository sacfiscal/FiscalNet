using FiscalNet.Implementacoes.COFINS;
using FiscalNet.Implementacoes.PIS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.COFINS
{
    [TestClass]
    public class Cofins03Test
    {
        [TestMethod]
        public void TestarCofins03()
        {
            decimal quantidadeTributada = 15.00M;
            decimal aliquotaUnidade = 0.764M;

            Cofins03 cofins03 = new Cofins03(quantidadeTributada, aliquotaUnidade);

            decimal vPIS = cofins03.ValorCofins();

            Assert.IsTrue(vPIS.Equals(11.46M));
        }
    }
}
