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
			throw new System.NotImplementedException();
		}

		public void Adicionar(InstituicaoViewModel obj)
		{
			var instituicao = Mapper.Map<InstituicaoViewModel, Instituicao>(obj);
			_instituicaoService.Adicionar(instituicao);
		}

		public InstituicaoViewModel ObterPorId(Guid id)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<InstituicaoViewModel> ObterTodos()
		{
			var todos = _instituicaoService.ObterTodos();
			return Mapper.Map<IEnumerable<Instituicao>, IEnumerable<InstituicaoViewModel>>(todos); ;
		}

		public void Atualizar(InstituicaoViewModel obj)
		{
			throw new System.NotImplementedException();
		}

		public void Remover(InstituicaoViewModel obj)
		{
			throw new System.NotImplementedException();
		}

		public IEnumerable<InstituicaoViewModel> ObterPorCNPJ(string cnpj)
		{
			throw new System.NotImplementedException();
		}
	}
}