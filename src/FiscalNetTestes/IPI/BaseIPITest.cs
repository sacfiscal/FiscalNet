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
    public class BaseIPITest
    {
        [TestMethod]
        public void TestarBaseIPI()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            
            BaseIPI baseIpi = new BaseIPI(valorProduto, valorFrete, valorSeguro, despesasAcessorias);

            decimal vBC = baseIpi.CalcularBaseIPI();

            Assert.IsTrue(vBC.Equals(186.95M));
        }
    }
}


