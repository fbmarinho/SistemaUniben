using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Infra.Data.EntityConfig.AbstractConfig;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class InstituicaoConfiguration : PessoaJuridicaConfiguration<Instituicao>
	{
		public InstituicaoConfiguration()
		{
			ToTable("Instituicoes");
			HasKey(p => p.InstituicaoId);

			// Relacionamentos Muitos para Muitos
			HasMany(e => e.Enderecos)
				.WithMany()
				.Map(me =>
				{
					me.MapLeftKey("InstituicaoId");
					me.MapRightKey("OwnerId");
					me.ToTable("InstituicaoEndereco");
				});
		}
		
	}
}