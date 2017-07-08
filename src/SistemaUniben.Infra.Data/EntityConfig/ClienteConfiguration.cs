using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
	{

		public ClienteConfiguration()
		{
			ToTable("Clientes");
			HasKey(p => p.ClienteId);

			Property(p => p.Nome).HasMaxLength(200);
			Property(p => p.Sobrenome).HasMaxLength(200);
			Property(p => p.CPF).IsRequired();

			// Relacionamentos Muitos para Muitos
			HasMany(e => e.Enderecos)
				.WithMany()
				.Map(me =>
				{
					me.MapLeftKey("ClienteId");
					me.MapRightKey("OwnerId");
					me.ToTable("ClienteEndereco");
				});
		}
	}
}