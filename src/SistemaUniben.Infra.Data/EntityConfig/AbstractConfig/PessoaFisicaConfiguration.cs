using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Infra.Data.EntityConfig.AbstractConfig
{
	public class PessoaFisicaConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : PessoaFisica
	{
		public PessoaFisicaConfiguration()
		{
			Property(p => p.Nome).HasMaxLength(300);
			Property(p => p.Sobrenome).HasMaxLength(200);
			Property(p => p.CPF).HasMaxLength(11).IsRequired();
		}
	}
}