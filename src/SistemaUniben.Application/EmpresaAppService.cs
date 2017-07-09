using System;
using System.Collections.Generic;
using AutoMapper;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Application
{
	public class EmpresaAppService : IEmpresaAppService
	{
		private readonly IEmpresaService _empresaService;

		public EmpresaAppService(IEmpresaService empresaService)
		{
			_empresaService = empresaService;
		}

		public void Dispose()
		{
			_empresaService.Dispose();
			GC.SuppressFinalize(this);
		}

		public void Adicionar(EmpresaViewModel obj)
		{
			var objeto = Mapper.Map<EmpresaViewModel, Empresa>(obj);
			_empresaService.Adicionar(objeto);
		}

		public EmpresaViewModel ObterPorId(Guid id)
		{
			var objeto = _empresaService.ObterPorId(id);
			return Mapper.Map<Empresa, EmpresaViewModel>(objeto);
		}

		public IEnumerable<EmpresaViewModel> ObterTodos()
		{
			var objeto = _empresaService.ObterTodos();
			return Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(objeto);
		}

		public void Atualizar(EmpresaViewModel obj)
		{
			var objeto = Mapper.Map<EmpresaViewModel, Empresa>(obj);
			_empresaService.Atualizar(objeto);
		}

		public void Remover(EmpresaViewModel obj)
		{
			var objeto = Mapper.Map<EmpresaViewModel, Empresa>(obj);
			_empresaService.Remover(objeto);
		}

		public IEnumerable<EmpresaViewModel> ObterPorCNPJ(string cnpj)
		{
			var objeto = _empresaService.ObterPorCNPJ(cnpj);
			return Mapper.Map<IEnumerable<Empresa>, IEnumerable<EmpresaViewModel>>(objeto);
		}
	}
}