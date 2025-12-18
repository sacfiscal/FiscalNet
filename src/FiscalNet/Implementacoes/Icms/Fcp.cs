using FiscalNet.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiscalNet.Implementacoes.Icms
{
    public class Fcp : IFcp
    {
        // A Base de FCP será a mesma base de icms próprio utilizada na operação
        private decimal BaseCalculo { get; set; }
        private decimal AliquotaFCP { get; set; }

        public Fcp(decimal baseCalculo, decimal aliquotaFCP)
        {
            this.BaseCalculo = baseCalculo;
            this.AliquotaFCP = aliquotaFCP;
        }

        public decimal ValorFCP()
        {
            return decimal.Round((AliquotaFCP / 100 * BaseCalculo), 2, MidpointRounding.ToEven);
        }
    }
}
