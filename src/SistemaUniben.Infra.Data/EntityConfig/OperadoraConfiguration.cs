using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class OperadoraConfiguration : EntityTypeConfiguration<Operadora>
	{
		public OperadoraConfiguration()
		{
			ToTable("Operadoras");
			HasKey(p => p.OperadoraId);
			Property(p => p.OperadoraId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(p => p.CNPJ).HasMaxLength(15);
			Property(p => p.Nome).HasMaxLength(200);
			Property(p => p.NomeFantasia).HasMaxLength(200);
			Property(p => p.Situacao).HasMaxLength(200);
			Property(p => p.Telefone).HasMaxLength(11);
			Property(p => p.Email).HasMaxLength(200);
			//Property(p => p.DataAbertura)
			Property(p => p.NaturezaJuridica).HasMaxLength(100);
			Property(p => p.Atividade).HasMaxLength(200);
			Property(p => p.Codigo).HasMaxLength(100);

			// Endereço
			Property(p => p.CEP).HasMaxLength(8);
			Property(p => p.Logradouro).HasMaxLength(200);
			Property(p => p.Numero).HasMaxLength(10);
			Property(p => p.Complemento).HasMaxLength(30);
			Property(p => p.Bairro).HasMaxLength(100);
			Property(p => p.Cidade).HasMaxLength(100);
			Property(p => p.Estado).HasMaxLength(100);

			// Uso Interno
			Property(p => p.Ativo).IsRequired();
			Property(p => p.DataCadastro).IsRequired();
			Property(p => p.DataExclusao).IsOptional();
		}
	}
}