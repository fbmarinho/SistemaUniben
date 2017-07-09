using System;
using System.Collections.Generic;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Application.Interfaces
{
	public interface IOperadoraAppService : IBaseAppService<OperadoraViewModel>, IPessoaJuridicaAppService<OperadoraViewModel>
	{
		// CRUD
	}
}