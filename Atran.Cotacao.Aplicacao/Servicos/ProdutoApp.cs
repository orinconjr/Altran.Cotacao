using Altran.Cotacao.Aplicacao.DTO;
using Altran.Cotacao.Aplicacao.Interfaces;
using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Dominio.Interfaces.Servicos;
using Altran.Cotacao.Dominio.Servicos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.Servicos
{
    public class ProdutoApp : ServicoAppBase<Produto, ProdutoDTO>, IProdutoApp
    {
        public ProdutoApp(IMapper iMapper, IProdutoServico servico) : base(iMapper, servico)
        {

        }
    }
}
