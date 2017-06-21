using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Domain.Services
{
	public class OperadoraService : IOperadoraService
	{
		protected readonly IOperadoraRepository _operadoraRepository;

		public OperadoraService(IOperadoraRepository operadoraRepository)
		{
			_operadoraRepository = operadoraRepository;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void Adicionar(Operadora obj)
		{
			_operadoraRepository.Add(obj);
		}

		public Operadora ObterPorId(int id)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Operadora> ObterTodos()
		{
			return _operadoraRepository.GetAll();
		}

		public void Atualizar(Operadora obj)
		{
			throw new NotImplementedException();
		}

		public void Remover(Operadora obj)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Operadora> Buscar(Expression<Func<Operadora, bool>> predicate)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Cliente> ObterPorCNPJ(string cnpj)
		{
			throw new NotImplementedException();
		}
	}
}