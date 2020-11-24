using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Dominio.Interfaces.Repositorios;
using Altran.Cotacao.Dominio.Interfaces.Servicos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Dominio.Servicos
{
    public class ServicoBase<TEntidade> : IServicoBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly IRepositorioBase<TEntidade> repositorio;

        public ServicoBase(IRepositorioBase<TEntidade> repositorio)
        {
            this.repositorio = repositorio;
        }

        public void Alterar(TEntidade entidade)
        {
            repositorio.Alterar(entidade);
        }

        public void Excluir(TEntidade entidade)
        {
            repositorio.Excluir(entidade);
        }

        public void Excluir(int id)
        {
            repositorio.Excluir(id);    
        }

        public int Incluir(TEntidade entidade)
        {
           return  repositorio.Incluir(entidade);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return repositorio.SelecionarTodos();
        }

        public TEntidade SelecionarPorId(int id)
        {
            return repositorio.SelecionarPorId(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos(TEntidade entidade)
        {
            return repositorio.SelecionarTodos(entidade);
        }

        
    }
}
