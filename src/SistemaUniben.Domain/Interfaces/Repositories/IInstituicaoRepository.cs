using System.Collections.Generic;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IInstituicaoRepository : IBaseRepository<Instituicao>
	{
		IEnumerable<Instituicao> GetByCNPJ(string cnpj);
	}
}