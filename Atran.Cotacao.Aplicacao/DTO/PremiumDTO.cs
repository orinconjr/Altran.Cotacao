using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class PremiumDTO
    {

        public decimal AnnualNet { get; set; }
        public decimal AnnualIof { get; set; }
        public decimal AnnualTotal { get; set; }
        public decimal MonthlyNet { get; set; }
        public decimal MonthlyIof { get; set; }
        public decimal MonthlyTotal { get; set; }
    }
}
