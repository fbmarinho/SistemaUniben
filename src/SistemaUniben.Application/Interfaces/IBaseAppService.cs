using System;
using System.Collections.Generic;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Application.Interfaces
{
	public interface IBaseAppService<TEntity> : IDisposable where TEntity : class
	{
		void Adicionar(TEntity obj);
		TEntity ObterPorId(Guid id);
		IEnumerable<TEntity> ObterTodos();
		void Atualizar(TEntity obj);
		void Remover(TEntity obj);
	}
}