using System.Collections.Generic;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IClienteService : IBaseService<Cliente>
	{
		IEnumerable<Cliente> ObterPorNome(string nome);
	}
}