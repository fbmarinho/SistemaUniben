using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Application.Interfaces
{
	public interface IEmpresaAppService : IBaseAppService<EmpresaViewModel>, IPessoaJuridicaAppService<EmpresaViewModel>
	{
		
	}
}