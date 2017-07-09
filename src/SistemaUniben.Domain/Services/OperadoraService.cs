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
		private readonly IOperadoraRepository _operadoraRepository;

		public OperadoraService(IOperadoraRepository operadoraRepository)
		{
			_operadoraRepository = operadoraRepository;
		}

		public IEnumerable<Operadora> ObterPorCNPJ(string cnpj)
		{
			return _operadoraRepository.GetByCNPJ(cnpj);
		}

		public void Dispose()
		{
			_operadoraRepository.Dispose();
		}

		public void Adicionar(Operadora obj)
		{
			_operadoraRepository.Add(obj);
		}

		public Operadora ObterPorId(Guid id)
		{
			return _operadoraRepository.GetById(id);
		}

		public IEnumerable<Operadora> ObterTodos()
		{
			return _operadoraRepository.GetAll();
		}

		public void Atualizar(Operadora obj)
		{
			_operadoraRepository.Update(obj);
		}

		public void Remover(Operadora obj)
		{
			_operadoraRepository.Remove(obj);
		}

		public IEnumerable<Operadora> Buscar(Expression<Func<Operadora, bool>> predicate)
		{
			return _operadoraRepository.Find(predicate);
		}
	}
}