using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class RequestDTO
    {
        public string Code { get; set; }    //"code": "XPTO",
        public CustomerDTO CustomerDTO { get; set; } //"customer": {
        public ParameterDTO ParameterDTO { get; set; } // "parameters": {
        public BasicDTO BasicDTO { get; set; } //"basic": {
        public List<OptionalDTO> OptionalDTO { get; set; } //   "optional": [
       
    }
}
