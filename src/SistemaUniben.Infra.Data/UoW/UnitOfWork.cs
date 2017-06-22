using System;
using Microsoft.Practices.ServiceLocation;
using SistemaUniben.Infra.Data.Context;
using SistemaUniben.Infra.Data.Interfaces;

namespace SistemaUniben.Infra.Data.UoW
{
	public class UnitOfWork : IUnitofWork
	{

		private readonly SistemaUnibenContext _context;
		private readonly ContextManager _contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;

		private bool _disposed;

		public UnitOfWork()
		{
			_context = _contextManager.GetContext();
		}
		public void BeginTransaction()
		{
			_disposed = false;
		}

		public void SaveChanges()
		{
			_context.SaveChanges();
		}

		protected virtual void Dispose(bool disposing)
		{
			if (!_disposed)
			{
				if (disposing)
				{
					_context.Dispose();
				}
			}
			_disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}