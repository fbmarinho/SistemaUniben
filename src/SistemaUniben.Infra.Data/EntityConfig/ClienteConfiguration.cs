using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Infra.Data.EntityConfig.AbstractConfig;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class ClienteConfiguration : PessoaFisicaConfiguration<Cliente>
	{

		public ClienteConfiguration()
		{
			ToTable("Clientes");
			HasKey(p => p.ClienteId);


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