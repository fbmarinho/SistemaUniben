using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Microsoft.Practices.ServiceLocation;
using SistemaUniben.Domain.Entities.Abstract;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Infra.Data.Context;
using SistemaUniben.Infra.Data.Interfaces;

namespace SistemaUniben.Infra.Data.Repositories
{
	public class PessoaJuridicaRepository<TEntity> : IPessoaJuridicaRepository<TEntity> where TEntity : PessoaJuridica
	{
		private readonly ContextManager _contextManager = ServiceLocator.Current.GetInstance<IContextManager>() as ContextManager;
		protected readonly SistemaUnibenContext Context;
		protected DbSet<TEntity> DbSet;

		public IEnumerable<TEntity> GetByCNPJ(string cnpj)
		{
			return DbSet.Where(q => q.CNPJ == cnpj);
		}
	}
}