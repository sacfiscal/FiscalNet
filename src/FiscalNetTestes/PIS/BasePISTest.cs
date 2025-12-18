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
    public class BasePISTest
    {
        [TestMethod]
        public void TestarBasePIS()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            decimal valorDesconto = 9.92M;

            BasePIS basePis = new BasePIS(valorProduto, valorFrete,
                valorSeguro, despesasAcessorias, valorDesconto);

            decimal vBC = basePis.CalcularBasePIS();
            Assert.IsTrue(vBC.Equals(177.03M));
        }
    }
}
