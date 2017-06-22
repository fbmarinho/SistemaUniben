using Microsoft.Practices.ServiceLocation;
using SistemaUniben.Infra.Data.Interfaces;

namespace SistemaUniben.Application
{
	public class AppServiceBase
	{
		private IUnitofWork _uow;
		public void BeginTransaction()
		{
			_uow = ServiceLocator.Current.GetInstance<IUnitofWork>();
			_uow.BeginTransaction();
		}

		public void Commit()
		{
			_uow.SaveChanges();
		}

	}
}