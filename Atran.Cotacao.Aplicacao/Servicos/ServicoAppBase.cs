using Altran.Cotacao.Aplicacao.DTO;
using Altran.Cotacao.Aplicacao.Interfaces;
using Altran.Cotacao.Dominio.Entidades;
using Altran.Cotacao.Dominio.Interfaces.Servicos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Altran.Cotacao.Aplicacao.Servicos
{
    public class ServicoAppBase<TEntidade, TEntidadeDTO> : IAppBase<TEntidade, TEntidadeDTO> where TEntidade : EntidadeBase where TEntidadeDTO : BaseDTO
    {
        protected readonly IServicoBase<TEntidade> _servico;
        protected readonly IMapper _iMapper;

        public ServicoAppBase(IMapper iMapper, IServicoBase<TEntidade> servico) : base()
        {
            _iMapper = iMapper;
            _servico = servico;
        }

        public void Alterar(TEntidadeDTO entidade)
        {
            _servico.Alterar(_iMapper.Map<TEntidade>(entidade));
        }

        public void Excluir(int id)
        {
            _servico.Excluir(id);
        }

        public void Excluir(TEntidadeDTO entidade)
        {
            _servico.Excluir(_iMapper.Map<TEntidade>(entidade));
        }

        public int Incluir(TEntidadeDTO entidade)
        {
            return _servico.Incluir(_iMapper.Map<TEntidade>(entidade));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos(TEntidade entidade)
        {
            return _iMapper.Map<IEnumerable<TEntidadeDTO>>(_servico.SelecionarTodos(entidade));
        }

        public TEntidadeDTO SelecionarPorId(int id)
        {
            return _iMapper.Map<TEntidadeDTO>(_servico.SelecionarPorId(id));
        }

        public IEnumerable<TEntidadeDTO> SelecionarTodos()
        {
            return _iMapper.Map<IEnumerable<TEntidadeDTO>>(_servico.SelecionarTodos());
        }
    }
}
