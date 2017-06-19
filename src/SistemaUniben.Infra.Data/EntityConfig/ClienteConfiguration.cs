using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
	{

		public ClienteConfiguration()
		{
			ToTable("CLientes");
			HasKey(p => p.ClienteId);
			Property(p => p.Nome).HasMaxLength(200);
			Property(p => p.Sobrenome).HasMaxLength(200);
		}
	}
}