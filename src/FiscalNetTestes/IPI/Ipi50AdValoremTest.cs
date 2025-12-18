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
    public class Ipi50AdValoremTest
    {
        [TestMethod]
        public void TestarIpi50AdValorem()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;           
            decimal aliquotaIPI = 10.00M;

            Ipi50AdValorem ipi50AV = new Ipi50AdValorem(valorProduto, valorFrete, valorSeguro, 
                                                                despesasAcessorias, aliquotaIPI);

            decimal vBC = ipi50AV.CalcularBaseIPI();

            decimal vIPI = ipi50AV.ValorIPI();

            Assert.IsTrue(vBC.Equals(186.95M));
            Assert.IsTrue(vIPI.Equals(18.70M));
        }
    }
}
