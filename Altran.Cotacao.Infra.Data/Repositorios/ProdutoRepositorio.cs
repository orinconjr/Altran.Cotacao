using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Dominio.Interfaces.Repositorios;
using Altran.Cotacao.Infra.Data.Contextos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Infra.Data.Repositorios
{
    public class ProdutoRepositorio : RepositorioBase<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(Contexto contexto) : base(contexto)
        {

        }
    }
}
