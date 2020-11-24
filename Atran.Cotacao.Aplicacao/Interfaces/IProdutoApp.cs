using Altran.Cotacao.Aplicacao.DTO;
using Altran.Cotacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.Interfaces
{
    public interface IProdutoApp : IAppBase<Produto, ProdutoDTO>
    {
    }
}
