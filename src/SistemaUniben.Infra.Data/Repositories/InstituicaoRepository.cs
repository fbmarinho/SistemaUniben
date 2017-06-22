using System;
using System.Collections.Generic;
using System.Linq;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;

namespace SistemaUniben.Infra.Data.Repositories
{
	public class InstituicaoRepository : BaseRepository<Instituicao>, IInstituicaoRepository
	{
		public IEnumerable<Instituicao> GetByCNPJ(string cnpj)
		{
			return Find(c => c.CNPJ == cnpj).ToList(); ;
		}
	}
}