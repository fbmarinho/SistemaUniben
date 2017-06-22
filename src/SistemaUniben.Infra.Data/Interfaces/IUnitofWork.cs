namespace SistemaUniben.Infra.Data.Interfaces
{
	public interface IUnitofWork
	{
		void BeginTransaction();
		void SaveChanges();
	}
}