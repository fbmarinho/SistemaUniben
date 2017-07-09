using System.Collections.Generic;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Interfaces.Repositories
{
	public interface IPessoaJuridicaRepository<TEntity> where TEntity : PessoaJuridica
	{
		IEnumerable<TEntity> GetByCNPJ(string cnpj);
	}
}