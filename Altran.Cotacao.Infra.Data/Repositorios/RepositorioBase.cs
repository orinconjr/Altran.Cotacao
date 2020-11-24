using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Dominio.Interfaces.Repositorios;
using Altran.Cotacao.Infra.Data.Contextos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Altran.Cotacao.Infra.Data.Repositorios
{
    public class RepositorioBase<TEntidade> : IRepositorioBase<TEntidade> where TEntidade : EntidadeBase
    {
        protected readonly Contexto _contexto;

        public RepositorioBase(Contexto contexto) : base()
        {
            _contexto = contexto;
        }

        public void Alterar(TEntidade entidade)
        {
            //_contexto.IniciarTransacao();
            _contexto.Set<TEntidade>().Attach(entidade);
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SendChanges();
        }

        public void Excluir(int id)
        {
            var entidade = SelecionarPorId(id);
            if (entidade != null)
            {
                //_contexto.IniciarTransacao();
                _contexto.Set<TEntidade>().Remove(entidade);
                _contexto.SendChanges();
            }
        }

        public void Excluir(TEntidade entidade)
        {
            //_contexto.IniciarTransacao();
            _contexto.Set<TEntidade>().Remove(entidade);
            _contexto.SendChanges();
        }

        public int Incluir(TEntidade entidade)
        {
            //_contexto.IniciarTransacao();
            var id = _contexto.Set<TEntidade>().Add(entidade).Entity.Id;
            return id;
        }

        public IEnumerable<TEntidade> SelecionarTodos(TEntidade entidade)
        {
            return _contexto.Set<TEntidade>().ToList();
        }

        public TEntidade SelecionarPorId(int id)
        {
            return _contexto.Set<TEntidade>().Find(id);
        }

        public IEnumerable<TEntidade> SelecionarTodos()
        {
            return _contexto.Set<TEntidade>().ToList();
        }
    }
}
