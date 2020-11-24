using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class BasicDTO
    {
        [Required]
        public string Product { get; set; } //"product": "DT30F",
        [Required]
        public decimal Capital { get; set; } //"capital": 300000.00
        public PremiumDTO PremiumDTO { get; set; }
    }
}
