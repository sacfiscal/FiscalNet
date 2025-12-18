using FiscalNet.Implementacoes.PIS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.PIS
{
    [TestClass]
    public class Pis01_02Test
    {
        [TestMethod]
        public void TestarPis01_02()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            decimal valorDesconto = 9.92M;
            decimal aliquotaPIS = 0.65M;

            Pis01_02 pis01_02 = new Pis01_02(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                                                                            valorDesconto, aliquotaPIS);

            decimal vBC = pis01_02.BasePis();

            decimal vPIS = pis01_02.ValorPis();

            Assert.IsTrue(vBC.Equals(177.03M));
            Assert.IsTrue(vPIS.Equals(1.15M));
        }
    }
}
