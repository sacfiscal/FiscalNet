using FiscalNet.Implementacoes.IBSCBS;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiscalNetTestes.IBSCBS
{
    [TestClass]
    public class IBSUFTest
    {
        [TestMethod]
        public void TestarIbsUf()
        {            
            decimal vBC = 100.50M;

            IbsUf ibsUf = new IbsUf(vBC, 60, 0, 0.1M, 0);
            
            Assert.IsTrue(ibsUf.ValorIbsUf().Equals(0.04M));
            Assert.IsTrue(ibsUf.AliquotaEfetiva().Equals(0.04M));
            Assert.IsTrue(ibsUf.Diferimento().Equals(0M));
        }
    }
}
