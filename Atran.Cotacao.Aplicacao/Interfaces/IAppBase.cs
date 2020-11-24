using Altran.Cotacao.Aplicacao.DTO;
using Altran.Cotacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.Interfaces
{
    public interface IAppBase<TEntidade, TEntidadeDTO> where TEntidade : EntidadeBase where TEntidadeDTO : BaseDTO
    {
        IEnumerable<TEntidadeDTO> SelecionarTodos(TEntidade entidade);
        int Incluir(TEntidadeDTO entidade);
        void Excluir(int id);
        void Excluir(TEntidadeDTO entidade);
        void Alterar(TEntidadeDTO entidade);
        TEntidadeDTO SelecionarPorId(int id);
        IEnumerable<TEntidadeDTO> SelecionarTodos();

        

    }
}
