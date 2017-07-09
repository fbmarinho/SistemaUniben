using System.Collections.Generic;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IPessoaJuridicaService<TEntity> where TEntity : class
	{
		IEnumerable<TEntity> ObterPorCNPJ(string cnpj);
	}
}