using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class FcpST : IFcpST
    {
        // A Base de FCP será a mesma base de icms st utilizada na operação
        private decimal BaseCalculoST { get; set; }
        private decimal AliquotaFCPST { get; set; }

        public FcpST(decimal baseCalculo, decimal aliquotaFCP)
        {
            this.BaseCalculoST = baseCalculo;
            this.AliquotaFCPST = aliquotaFCP;
        }

        public decimal ValorFCPST()
        {
            return decimal.Round((AliquotaFCPST / 100 * BaseCalculoST), 2, MidpointRounding.ToEven);
        }
    }
}
