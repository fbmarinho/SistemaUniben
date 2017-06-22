using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IBaseRepository<TEntity> : IDisposable where TEntity : class
	{
		void Add(TEntity obj);
		TEntity GetById(int id);
		IEnumerable<TEntity> GetAll();
		void Update(TEntity obj);
		void Remove(TEntity obj);
		IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
		void SaveChanges();
	}
}