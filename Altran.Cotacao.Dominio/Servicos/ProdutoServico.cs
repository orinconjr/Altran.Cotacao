using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Dominio.Interfaces.Repositorios;
using Altran.Cotacao.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Dominio.Servicos
{
    public class ProdutoServico : ServicoBase<Produto>, IProdutoServico
    {
        public ProdutoServico(IProdutoRepositorio repositorio) : base(repositorio)
        {

        }
    }
}
