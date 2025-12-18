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
    public class FcpTest
    {
        [TestMethod]
        public void TestarFcp()
        {
            decimal baseFcp = 135.00M;            
            decimal aliquotaFcp = 2.00M;

            Fcp fcp = new Fcp(baseFcp, aliquotaFcp);            

            decimal vFCP = fcp.ValorFCP();

            Assert.IsTrue(vFCP.Equals(2.70M));            
        }
    }
}
