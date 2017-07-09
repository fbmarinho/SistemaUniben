using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Infra.Data.EntityConfig.AbstractConfig;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class EmpresaConfiguration : PessoaJuridicaConfiguration<Empresa>
	{
		public EmpresaConfiguration()
		{
			ToTable("Empresas");
			HasKey(p => p.EmpresaId);

			// Relacionamentos Muitos para Muitos
			HasMany(e => e.Enderecos)
				.WithMany()
				.Map(me =>
				{
					me.MapLeftKey("EmpresaId");
					me.MapRightKey("OwnerId");
					me.ToTable("EmpresaEndereco");
				});
		}
	}
}