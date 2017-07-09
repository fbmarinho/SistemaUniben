using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IEmpresaService : IBaseService<Empresa>, IPessoaJuridicaService<Empresa>
	{
		// Métodos específicos
	}
}