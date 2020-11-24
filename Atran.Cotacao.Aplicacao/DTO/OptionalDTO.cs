using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class OptionalDTO
    {
        public string Product { get; set; }
        public decimal Capital { get; set; }
        public PremiumDTO premiumDTO { get; set; }
    }
}
