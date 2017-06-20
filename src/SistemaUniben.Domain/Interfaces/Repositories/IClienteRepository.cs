using System.Collections.Generic;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IClienteRepository : IBaseRepository<Cliente>
	{
		IEnumerable<Cliente> GetByName(string name);
	}
}