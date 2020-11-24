using Altran.Cotacao.Aplicacao.DTO;
using Altran.Cotacao.Dominio.Entidades;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao
{
    public class MappingEntidade : Profile
    {
        public MappingEntidade()
        {
            CreateMap<Produto, ProdutoDTO>();
            CreateMap<ProdutoDTO, Produto>();

            
        }
    }
}
