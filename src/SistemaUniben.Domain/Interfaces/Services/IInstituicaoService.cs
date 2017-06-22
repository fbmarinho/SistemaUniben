using System.Collections.Generic;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Domain.Interfaces.Services
{
	public interface IInstituicaoService : IBaseService<Instituicao>
	{
			IEnumerable<Instituicao> ObterPorCNPJ(string cnpj);
	}
}