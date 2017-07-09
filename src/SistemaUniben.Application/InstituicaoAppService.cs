using System;
using System.Collections.Generic;
using AutoMapper;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Application
{
	public class InstituicaoAppService: IInstituicaoAppService
	{

		private readonly IInstituicaoService _instituicaoService;

		public InstituicaoAppService(IInstituicaoService instituicaoService)
		{
			_instituicaoService = instituicaoService;
		}

		public void Dispose()
		{
			_instituicaoService.Dispose();
			GC.SuppressFinalize(this);
		}

		public void Adicionar(InstituicaoViewModel obj)
		{
			var instituicao = Mapper.Map<InstituicaoViewModel, Instituicao>(obj);
			_instituicaoService.Adicionar(instituicao);
		}

		public InstituicaoViewModel ObterPorId(Guid id)
		{
			var objeto = _instituicaoService.ObterPorId(id);
			return Mapper.Map<Instituicao, InstituicaoViewModel>(objeto);
		}

		public IEnumerable<InstituicaoViewModel> ObterTodos()
		{
			var todos = _instituicaoService.ObterTodos();
			return Mapper.Map<IEnumerable<Instituicao>, IEnumerable<InstituicaoViewModel>>(todos); ;
		}

		public void Atualizar(InstituicaoViewModel obj)
		{
			var objeto = Mapper.Map<InstituicaoViewModel, Instituicao>(obj);
			_instituicaoService.Atualizar(objeto);
		}

		public void Remover(InstituicaoViewModel obj)
		{
			var objeto = Mapper.Map<InstituicaoViewModel, Instituicao>(obj);
			_instituicaoService.Remover(objeto);
		}

		public IEnumerable<InstituicaoViewModel> ObterPorCNPJ(string cnpj)
		{
			var objeto = _instituicaoService.ObterPorCNPJ(cnpj);
			return Mapper.Map<IEnumerable<Instituicao>, IEnumerable<InstituicaoViewModel>>(objeto); ;
		}
	}
}