using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Repositories;

namespace SistemaUniben.Infra.Data.Repositories
{
	public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
	{
		public IEnumerable<Empresa> GetByCNPJ(string cnpj)
		{
			throw new NotImplementedException();
		}
	}
}