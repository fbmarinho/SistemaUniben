using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Infra.Data.EntityConfig.AbstractConfig
{
	public class PessoaJuridicaConfiguration<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : PessoaJuridica
	{
		public PessoaJuridicaConfiguration()
		{
			Property(p => p.CNPJ).HasMaxLength(15);
			Property(p => p.Nome).HasMaxLength(200);
			Property(p => p.NomeFantasia).HasMaxLength(300);
			Property(p => p.Situacao).HasMaxLength(200);
			Property(p => p.Telefone).HasMaxLength(11);
			Property(p => p.Email).HasMaxLength(200);
			Property(p => p.DataAbertura).IsRequired();
			Property(p => p.NaturezaJuridica).HasMaxLength(100);
			Property(p => p.Atividade).HasMaxLength(200);
			Property(p => p.Codigo).HasMaxLength(100);
		}
	}
}