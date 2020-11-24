using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Dominio.Entidades
{
    public class Produto : EntidadeBase
    {
        public string Product { get; set; } 
        public string Family_Id { get; set; } 
        public string Class { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public decimal Rate { get; set; }
        public decimal Capital { get; set; }

        public Produto()
        {

        }

        public Produto(decimal capital)
        {
            this.Capital = capital;
        }
    }
}
