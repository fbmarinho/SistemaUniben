using System.Collections.Generic;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Application.Interfaces
{
	public interface IInstituicaoAppService
	{
		// CRUD
		void Adicionar(InstituicaoViewModel obj);
		InstituicaoViewModel ObterPorId(int id);
		IEnumerable<InstituicaoViewModel> ObterTodos();
		void Atualizar(InstituicaoViewModel obj);
		void Remover(InstituicaoViewModel obj);

		// Métodos Especificos
		IEnumerable<InstituicaoViewModel> ObterPorCNPJ(string cnpj);
	}
}