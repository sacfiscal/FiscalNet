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
    public class BaseCofinsTest
    {
        [TestMethod]
        public void TestarBaseCofins()
        {
            decimal valorProduto = 180.00M;
            decimal valorFrete = 4.96M;
            decimal valorSeguro = 0.50M;
            decimal despesasAcessorias = 1.49M;
            decimal valorDesconto = 9.92M;

            BaseCofins CofinsPis = new BaseCofins(valorProduto, valorFrete,
                valorSeguro, despesasAcessorias, valorDesconto);

            decimal vBC = CofinsPis.CalcularBaseCofins();
            Assert.IsTrue(vBC.Equals(177.03M));
        }
    }
}
