using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
	{
		public ProdutoConfiguration()
		{
			ToTable("Produtos");
			HasKey(p => p.ProdutoId);
			
		
		}


	}
}