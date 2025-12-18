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
    public class FcpSTTest
    {
        [TestMethod]
        public void TestarFCSPST()
        {
            decimal baseFcpST = 135.00M;
            decimal aliquotaFcpST = 2.00M;

            FcpST fcpST = new FcpST(baseFcpST, aliquotaFcpST);

            decimal vFCPST = fcpST.ValorFCPST();

            Assert.IsTrue(vFCPST.Equals(2.70M));
        }
    }
}
