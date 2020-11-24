using Altran.Cotacao.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Dominio.Interfaces.Repositorios
{
    public interface IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        IEnumerable<TEntidade> SelecionarTodos(TEntidade entidade);
        int Incluir(TEntidade entidade);
        void Excluir(int id);
        void Excluir(TEntidade entidade);
        void Alterar(TEntidade entidade);
        TEntidade SelecionarPorId(int id);
        IEnumerable<TEntidade> SelecionarTodos();
    }
}
