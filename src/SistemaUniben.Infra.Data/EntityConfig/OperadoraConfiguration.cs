using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Infra.Data.EntityConfig.AbstractConfig;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class OperadoraConfiguration : PessoaJuridicaConfiguration<Operadora>
	{
		public OperadoraConfiguration()
		{
			ToTable("Operadoras");
			HasKey(p => p.OperadoraId);

			// Relacionamentos Muitos para Muitos
			HasMany(e => e.Enderecos)
				.WithMany()
				.Map(me =>
				{
					me.MapLeftKey("OperadoraId");
					me.MapRightKey("OwnerId");
					me.ToTable("OperadoraEndereco");
				});
		}
	}
}