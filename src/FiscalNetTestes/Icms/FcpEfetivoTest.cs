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
    public class FcpEfetivoTest
    {
        [TestMethod]
        public void TestarFcp()
        {
            decimal valorFcp = 5.00M;
            decimal valorFcpDiferido = 0.50M;

            FCPEfetivo fcpEfet = new FCPEfetivo(valorFcp, valorFcpDiferido);

            decimal vFCPEfet = fcpEfet.ValorFcpEfetivo();

            Assert.IsTrue(vFCPEfet.Equals(4.50M));
        }
    }
}
