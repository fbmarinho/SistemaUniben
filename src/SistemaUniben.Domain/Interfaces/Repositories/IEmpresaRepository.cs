using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IEmpresaRepository : IBaseRepository<Empresa>, IPessoaJuridicaRepository<Empresa>
	{
		//Métodos específicos
	}
}