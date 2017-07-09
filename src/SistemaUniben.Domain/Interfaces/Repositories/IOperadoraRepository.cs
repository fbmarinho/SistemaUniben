using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IOperadoraRepository: IBaseRepository<Operadora>, IPessoaJuridicaRepository<Operadora>
	{
		//Métodos especificos
	}
}