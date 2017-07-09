using System;
using System.Collections.Generic;
using AutoMapper;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Application
{
	public class OperadoraAppService: IOperadoraAppService
	{

		private readonly IOperadoraService _operadoraService;

		public OperadoraAppService(IOperadoraService operadoraService)
		{
			_operadoraService = operadoraService;
		}

		public void Dispose()
		{
			throw new System.NotImplementedException();
		}

		public void Adicionar(OperadoraViewModel obj)
		{
			var operadora = Mapper.Map<OperadoraViewModel, Operadora>(obj);
			_operadoraService.Adicionar(operadora);
		}

		public OperadoraViewModel ObterPorId(Guid id)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<OperadoraViewModel> ObterTodos()
		{
			var todos = _operadoraService.ObterTodos();
			return Mapper.Map<IEnumerable<Operadora>, IEnumerable<OperadoraViewModel>>(todos); ;
		}

		public void Atualizar(OperadoraViewModel obj)
		{
			throw new System.NotImplementedException();
		}

		public void Remover(OperadoraViewModel obj)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<OperadoraViewModel> ObterPorCNPJ(string cnpj)
		{
			throw new System.NotImplementedException();
		}
	}
}