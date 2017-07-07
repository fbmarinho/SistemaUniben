using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class EnderecoConfiguration : EntityTypeConfiguration<Endereco>
	{
		public EnderecoConfiguration()
		{
			ToTable("Enderecos");

			HasKey(e => e.EnderecoId);

			Property(e => e.Logradouro)
				.IsRequired()
				.HasMaxLength(300);

			Property(e => e.Cidade)
				.IsRequired()
				.HasMaxLength(50);

			Property(e => e.CEP)
				.IsRequired()
				.HasMaxLength(8);

			Property(e => e.Complemento)
				.HasMaxLength(300);

			// Relacionamentos
			

		}
	}
}