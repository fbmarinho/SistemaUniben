using SistemaUniben.Application.ViewModels;


namespace SistemaUniben.Application.Interfaces
{
	public interface IInstituicaoAppService : IBaseAppService<InstituicaoViewModel>, IPessoaJuridicaAppService<InstituicaoViewModel>
	{

	}
}