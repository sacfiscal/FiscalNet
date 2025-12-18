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
    public class FcpDiferidoTest
    {
        [TestMethod]
        public void TestarFcp()
        {
            decimal valorFcp = 5.00M;
            decimal aliquotaDiferimentoFcp = 10.00M;

            FcpDiferido fcpDif = new FcpDiferido(valorFcp, aliquotaDiferimentoFcp);

            decimal vFCPDif = fcpDif.ValorFCPDiferido();

            Assert.IsTrue(vFCPDif.Equals(0.50M));
        }
    }
}
