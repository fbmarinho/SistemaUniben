using System.Collections.Generic;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IOperadoraService : IBaseService<Operadora>
	{
		IEnumerable<Cliente> ObterPorCNPJ(string cnpj);
	}
}