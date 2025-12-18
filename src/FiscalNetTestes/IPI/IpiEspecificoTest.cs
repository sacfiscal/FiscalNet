using FiscalNet.Implementacoes.IPI;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.IPI
{
    [TestClass]
    public class IpiEspecificoTest
    {
        [TestMethod]
        public void TestarIpiEspecifico()
        {
            decimal quantidadeTributada = 15.00M;
            decimal aliquotaUnidade = 0.764M;

            Ipi50Especifico ipiEspecifico = new Ipi50Especifico(quantidadeTributada, aliquotaUnidade);

            decimal vIPI = ipiEspecifico.ValorIPI();

            Assert.IsTrue(vIPI.Equals(11.46M));
        }
    }
}
