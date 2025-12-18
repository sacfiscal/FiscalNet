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
    public class CBSTest
    {
        [TestMethod]
        public void TestarCbs()
        {
            decimal vBC = 100.50M;

            Cbs cbs = new Cbs(vBC, 60, 0, 0.9M, 0);
            Assert.IsTrue(cbs.ValorCbs().Equals(0.36M));
            Assert.IsTrue(cbs.AliquotaEfetiva().Equals(0.36M));
            Assert.IsTrue(cbs.Diferimento().Equals(0M));
        }
    }
}
