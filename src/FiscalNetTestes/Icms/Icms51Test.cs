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
    public class Icms51Test
    {
        [TestMethod]
        public void TestarIcms51()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 3.00M;
            decimal despesasAcessorias = 1.50M;
            decimal valorDesconto = 13.50M;
            decimal valorIpi = 15;
            decimal aliquotaIcmsProprio = 18.00M;
            decimal percentualReducao = 10.00M;
            decimal percentualDiferimento = 10.00M;

            Icms51 icms51 = new Icms51(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorIpi, valorDesconto, aliquotaIcmsProprio, percentualReducao, percentualDiferimento);

            decimal vBC = icms51.BaseIcmsProprio();
            decimal vICMSOp = icms51.ValorIcmsOperacao();
            decimal vICMSDif = icms51.ValorIcmsDiferido();
            decimal vICMS = icms51.ValorIcmsProprio();

            Assert.IsTrue(vBC.Equals(135.15M));
            Assert.IsTrue(vICMSOp.Equals(24.33M));
            Assert.IsTrue(vICMSDif.Equals(2.43M));
            Assert.IsTrue(vICMS.Equals(21.90M));
        }
    }
}
