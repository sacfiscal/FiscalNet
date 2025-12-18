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
    public class Icms70Test
    {
        [TestMethod]
        public void TestarIcms70()
        {
            decimal valorProduto = 135.00M;
            decimal valorFrete = 7.50M;
            decimal valorSeguro = 0.75M;
            decimal despesasAcessorias = 2.25M;
            decimal valorDesconto = 15.00M;
            decimal valorIpi = 15.00M;
            decimal aliquotaIcmsProprio = 12.00M;
            decimal aliquotaIcmsST = 18.00M;
            decimal mva = 40.65M;
            decimal percentualReducao = 10.00M;
            decimal percentualReducaoST = 10.00M;

            Icms70 icms70 = new Icms70(valorProduto, valorFrete, valorSeguro, despesasAcessorias,
                valorIpi, valorDesconto, aliquotaIcmsProprio, aliquotaIcmsST, mva, 
                percentualReducao, percentualReducaoST);

            decimal vBC = icms70.BaseIcmsProprio();

            decimal vICMS = icms70.ValorIcmsProprio();

            decimal vICMSDeson = icms70.ValorIcmsProprioDesonerado();

            decimal vBCST = icms70.BaseIcmsST();

            decimal vICMSST = icms70.ValorIcmsST();

            decimal vICMSSTDeson = icms70.ValorICMSSTDesonerado();

            Assert.IsTrue(vBC.Equals(117.45M));
            Assert.IsTrue(vICMS.Equals(14.09M));
            Assert.IsTrue(vICMSDeson.Equals(1.57M));
            Assert.IsTrue(vBCST.Equals(163.67M));
            Assert.IsTrue(vICMSST.Equals(15.37M));
            Assert.IsTrue(vICMSSTDeson.Equals(5.81M));
        }
    }
}
