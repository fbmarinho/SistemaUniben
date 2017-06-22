using SistemaUniben.Infra.Data.Context;

namespace SistemaUniben.Infra.Data.Interfaces
{
	public interface IContextManager
	{
		SistemaUnibenContext GetContext();
	}
}