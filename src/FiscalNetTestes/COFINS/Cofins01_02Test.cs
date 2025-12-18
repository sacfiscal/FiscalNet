using FiscalNet.Implementacoes.COFINS;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiscalNetTestes.COFINS
{
    [TestClass]
    public class Cofins01_02Test
    {
        [TestMethod]
        public void TestarCofins01_02()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            decimal valorDesconto = 9.92M;
            decimal aliquotaCOFINS = 3.00M;

            Cofins01_02 cofins01_02 = new Cofins01_02(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                                                                            valorDesconto, aliquotaCOFINS);

            decimal vBC = cofins01_02.BaseCofins();

            decimal vPIS = cofins01_02.ValorCofins();

            Assert.IsTrue(vBC.Equals(177.03M));
            Assert.IsTrue(vPIS.Equals(5.31M));
        }
    }
}
