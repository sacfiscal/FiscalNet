using FiscalNet.Implementacoes.IBSCBS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.IBSCBS
{
    [TestClass]
    public class IBSMunTest
    {
        [TestMethod]
        public void TestarIbsMun()
        {
            decimal vBC = 100.50M;

            IbsMun ibsMun = new IbsMun(vBC, 0, 0, 0, 0);

            Assert.IsTrue(ibsMun.ValorIbsMun().Equals(0));
            Assert.IsTrue(ibsMun.AliquotaEfetiva().Equals(0));
            Assert.IsTrue(ibsMun.Diferimento().Equals(0));
        }
    }
}
