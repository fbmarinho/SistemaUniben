using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaUniben.Application.ViewModels;

namespace SistemaUniben.Application.Interfaces
{
	public interface IClienteAppService : IDisposable
	{
		void Adicionar(ClienteViewModel obj);
		ClienteViewModel ObterPorId(int id);
		IEnumerable<ClienteViewModel> ObterTodos();
		void Atualizar(ClienteViewModel obj);
		void Remover(ClienteViewModel obj);
		IEnumerable<ClienteViewModel> ObterPorNome(string nome);
	}
}