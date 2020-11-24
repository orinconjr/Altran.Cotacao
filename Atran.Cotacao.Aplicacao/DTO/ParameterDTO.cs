using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class ParameterDTO
    {
        [Required]
        public int Age { get; set; } //"age": 30,
        [Required]
        public string Gender { get; set; } //"gender": "F",
        [Required]
        public string Class { get; set; } //"class": "Standard"
    }
}
