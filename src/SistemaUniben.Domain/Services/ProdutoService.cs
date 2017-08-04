using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;

namespace SistemaUniben.Domain.Services
{
	public class ProdutoService: IProdutoService
	{
		private readonly IProdutoRepository _produtoRepository;

		public ProdutoService(IProdutoRepository produtoRepository)
		{
			_produtoRepository = produtoRepository;
		}

		public void Dispose()
		{
			throw new NotImplementedException();
		}

		public void Adicionar(Produto obj)
		{
			throw new NotImplementedException();
		}

		public Produto ObterPorId(Guid id)
		{
			return _produtoRepository.GetById(id);
		}

		public IEnumerable<Produto> ObterTodos()
		{
			return _produtoRepository.GetAll();
		}

		public void Atualizar(Produto obj)
		{
			_produtoRepository.Update(obj);
		}

		public void Remover(Produto obj)
		{
			throw new NotImplementedException();
		}

		public IEnumerable<Produto> Buscar(Expression<Func<Produto, bool>> predicate)
		{
			throw new NotImplementedException();
		}
	}
}