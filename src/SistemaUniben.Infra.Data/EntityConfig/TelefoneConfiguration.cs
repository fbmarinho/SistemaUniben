using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class TelefoneConfiguration : EntityTypeConfiguration<Telefone>
	{
		public TelefoneConfiguration()
		{
			ToTable("Telefones");

			HasKey(e => e.TelefoneId);
		}
	}
}