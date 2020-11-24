using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class ProdutoDTO : BaseDTO
    {
        public string Product { get; set; }
        public string Family_Id { get; set; }
        public string Class { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Rate { get; set; }
        public decimal Capital { get; set; }
    }
}
