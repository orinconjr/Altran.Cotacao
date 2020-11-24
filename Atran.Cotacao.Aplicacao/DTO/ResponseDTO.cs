using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.DTO
{
    public class ResponseDTO
    {
        public string Code { get; set; }    //"code": "XPTO",
        public CustomerDTO CustomerDTO { get; set; } //"customer": {
        public ParameterDTO ParameterDTO { get; set; } // "parameters": {
        public BasicDTO BasicDTO { get; set; } //"basic": {
        public List<OptionalDTO> OptionalsDTO { get; set; } //   "optional": [
    }
}
