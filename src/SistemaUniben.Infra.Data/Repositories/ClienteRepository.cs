using System.Collections.Generic;
using System.Linq;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;

namespace SistemaUniben.Infra.Data.Repositories
{
	public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
	{
		public IEnumerable<Cliente> GetByName(string name)
		{
			return Find(c => c.Nome == name).ToList();
		}
	}
}