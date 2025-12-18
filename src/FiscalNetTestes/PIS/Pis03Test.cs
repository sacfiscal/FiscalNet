using FiscalNet.Implementacoes.PIS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.PIS
{
    [TestClass]
    public class Pis03Test
    {
        [TestMethod]
        public void TestarPis03()
        {
            decimal quantidadeTributada = 15.00M;
            decimal aliquotaUnidade = 0.764M;

            Pis03 pis03 = new Pis03(quantidadeTributada, aliquotaUnidade);

            decimal vPIS = pis03.ValorPis();

            Assert.IsTrue(vPIS.Equals(11.46M));
        }
        
    }
}
