using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IBaseService<TEntity> : IDisposable where TEntity : class 
	{
		void Adicionar(TEntity obj);
		TEntity ObterPorId(Guid id);
		IEnumerable<TEntity> ObterTodos();
		void Atualizar(TEntity obj);
		void Remover(TEntity obj);
		IEnumerable<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);
	}
}