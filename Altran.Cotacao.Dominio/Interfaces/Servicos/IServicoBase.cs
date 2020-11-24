using Altran.Cotacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Dominio.Interfaces.Servicos
{
    public interface IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        IEnumerable<TEntidade> SelecionarTodos(TEntidade entidade);
        int Incluir(TEntidade entidade);
        void Excluir(TEntidade entidade);
        void Excluir(int id);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
