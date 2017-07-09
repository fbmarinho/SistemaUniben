using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IInstituicaoService: IBaseService<Instituicao>, IPessoaJuridicaService<Instituicao>
	{
		
	}
}