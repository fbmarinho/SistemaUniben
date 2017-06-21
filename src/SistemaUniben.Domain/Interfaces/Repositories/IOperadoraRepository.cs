using System.Collections.Generic;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IOperadoraRepository : IBaseRepository<Operadora>
	{
		IEnumerable<Operadora> GetByCNPJ(string cnpj);
	}
}