using System.Collections.Generic;

namespace SistemaUniben.Application.Interfaces
{
	public interface IPessoaJuridicaAppService<TEntity> where TEntity : class
	{
		IEnumerable<TEntity> ObterPorCNPJ(string cnpj);
	}
}