using System;
using System.Collections.Generic;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Application.Interfaces
{
	public interface IOperadoraAppService : IDisposable
	{
		// CRUD
		void Adicionar(OperadoraViewModel obj);
		OperadoraViewModel ObterPorId(int id);
		IEnumerable<OperadoraViewModel> ObterTodos();
		void Atualizar(OperadoraViewModel obj);
		void Remover(OperadoraViewModel obj);

		// Métodos Especificos
		IEnumerable<OperadoraViewModel> ObterPorCNPJ(string cnpj);
	}
}