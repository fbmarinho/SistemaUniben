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
			_operadoraService.Dispose();
			GC.SuppressFinalize(this);
		}

		public void Adicionar(OperadoraViewModel obj)
		{
			var operadora = Mapper.Map<OperadoraViewModel, Operadora>(obj);
			_operadoraService.Adicionar(operadora);
		}

		public OperadoraViewModel ObterPorId(Guid id)
		{
			var objeto = _operadoraService.ObterPorId(id);
			return Mapper.Map<Operadora, OperadoraViewModel>(objeto);
		}

		public IEnumerable<OperadoraViewModel> ObterTodos()
		{
			var todos = _operadoraService.ObterTodos();
			return Mapper.Map<IEnumerable<Operadora>, IEnumerable<OperadoraViewModel>>(todos); ;
		}

		public void Atualizar(OperadoraViewModel obj)
		{
			var objeto = Mapper.Map<OperadoraViewModel, Operadora>(obj);
			_operadoraService.Atualizar(objeto);
		}

		public void Remover(Guid id)
		{
			_operadoraService.Remover(id);
		}

		public IEnumerable<OperadoraViewModel> ObterPorCNPJ(string cnpj)
		{
			var objeto = _operadoraService.ObterPorCNPJ(cnpj);
			return Mapper.Map<IEnumerable<Operadora>, IEnumerable<OperadoraViewModel>>(objeto);
		}
	}
}