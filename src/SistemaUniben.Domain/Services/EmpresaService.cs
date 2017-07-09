using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Domain.Services
{
	public class EmpresaService : IEmpresaService
	{
		private readonly IEmpresaRepository _empresaRepository;

		public EmpresaService(IEmpresaRepository empresaRepository)
		{

			_empresaRepository = empresaRepository;
		}

		public void Dispose()
		{
			_empresaRepository.Dispose();
			GC.SuppressFinalize(this);
		}

		public void Adicionar(Empresa obj)
		{
			_empresaRepository.Add(obj);
		}

		public Empresa ObterPorId(Guid id)
		{
			return _empresaRepository.GetById(id);
		}

		public IEnumerable<Empresa> ObterTodos()
		{
			return _empresaRepository.GetAll();
		}

		public void Atualizar(Empresa obj)
		{
			_empresaRepository.Update(obj);
		}

		public void Remover(Empresa obj)
		{
			_empresaRepository.Remove(obj);
		}

		public IEnumerable<Empresa> Buscar(Expression<Func<Empresa, bool>> predicate)
		{
			return _empresaRepository.Find(predicate);
		}

		public IEnumerable<Empresa> ObterPorCNPJ(string cnpj)
		{
			return _empresaRepository.GetByCNPJ(cnpj);
		}
	}
}