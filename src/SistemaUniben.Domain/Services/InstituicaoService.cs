using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Domain.Services
{
	public class InstituicaoService : IInstituicaoService
	{

		protected readonly IInstituicaoRepository _instituicaoRepository;

		public InstituicaoService(IInstituicaoRepository instituicaoRepository)
		{
			_instituicaoRepository = instituicaoRepository;
		}

		public void Dispose()
		{
			_instituicaoRepository.Dispose();
			GC.SuppressFinalize(this);
		}

		public void Adicionar(Instituicao obj)
		{
			_instituicaoRepository.Add(obj);
		}

		public Instituicao ObterPorId(Guid id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Instituicao> ObterTodos()
		{
			return _instituicaoRepository.GetAll();
		}

		public void Atualizar(Instituicao obj)
		{
			throw new NotImplementedException();
		}

		public void Remover(Instituicao obj)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Instituicao> Buscar(Expression<Func<Instituicao, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Instituicao> ObterPorCNPJ(string cnpj)
		{
			throw new NotImplementedException();
		}
	}
}