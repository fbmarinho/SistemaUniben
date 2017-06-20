using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Infra.Data.Context;

namespace SistemaUniben.Infra.Data.Repositories
{
	public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
	{
		protected readonly SistemaUnibenContext Context;
		protected DbSet<TEntity> DbSet;

		public BaseRepository()
		{
			Context = new SistemaUnibenContext();
			DbSet = Context.Set<TEntity>();
		}

		public void Add(TEntity obj)
		{
			DbSet.Add(obj);
		}

		public TEntity GetById(int id)
		{
			return DbSet.Find(id);
		}

		public IEnumerable<TEntity> GetAll()
		{
			return DbSet.ToList();
		}


		public void Update(TEntity obj)
		{
			var entry = Context.Entry(obj);
			DbSet.Attach(obj);
			entry.State = EntityState.Modified;

			Context.SaveChanges();
		}

		public void Remove(TEntity obj)
		{
			DbSet.Remove(obj);
		}

		public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
		{
			return DbSet.Where(predicate);
		}

		public void Dispose()
		{
			Context.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}