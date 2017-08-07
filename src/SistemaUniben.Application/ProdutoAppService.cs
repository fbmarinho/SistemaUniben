using System;
using System.Collections.Generic;
using AutoMapper;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Application
{
	public class ProdutoAppService : AppServiceBase, IProdutoAppService
	{

		private readonly IProdutoService _produtoService;

		public ProdutoAppService(IProdutoService produtoService)
		{
			_produtoService = produtoService;
		}

		public void Dispose()
		{
			_produtoService.Dispose();
			GC.SuppressFinalize(this);
		}

		public void Adicionar(ProdutoViewModel obj)
		{
			BeginTransaction();

			_produtoService.Adicionar(Mapper.Map<ProdutoViewModel, Produto>(obj));

			Commit();
		}

		public ProdutoViewModel ObterPorId(Guid id)
		{
			var produto = _produtoService.ObterPorId(id);
			return Mapper.Map<Produto, ProdutoViewModel>(produto);
		}

		public IEnumerable<ProdutoViewModel> ObterTodos()
		{
			var todos = _produtoService.ObterTodos();
			return Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(todos);
		}

		public void Atualizar(ProdutoViewModel obj)
		{
			BeginTransaction();

				_produtoService.Atualizar(Mapper.Map<ProdutoViewModel, Produto>(obj));

			Commit();
		}

		public void Remover(Guid id)
		{
			BeginTransaction();

				_produtoService.Remover(id);

			Commit();
		}
	}
}