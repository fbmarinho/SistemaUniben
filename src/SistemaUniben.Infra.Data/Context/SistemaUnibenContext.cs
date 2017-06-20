using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Infra.Data.EntityConfig;

namespace SistemaUniben.Infra.Data.Context
{
	public class SistemaUnibenContext : DbContext
	{
		public SistemaUnibenContext()
			:base("SistemaUnibenContext")
		{
			
		}

		public DbSet<Cliente> Clientes { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			//configuração do framework
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			//configuração de cada tabela
			modelBuilder.Configurations.Add(new ClienteConfiguration());


			//configuração das tabelas padrão
			modelBuilder.Properties().Where(p => p.Name == p.ReflectedType.Name + "Id").Configure(p => p.IsKey());
			modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
			modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(100));


			base.OnModelCreating(modelBuilder);
		}

		public override int SaveChanges()
		{
			foreach (var entry in ChangeTracker.Entries().Where(Entry => Entry.Entity.GetType().GetProperty("DataCadastro") != null))
			{
				if (entry.State == EntityState.Added)
				{
					entry.Property("DataCadastro").CurrentValue = DateTime.Now;
				}

				if (entry.State == EntityState.Modified)
				{
					entry.Property("DataCadastro").CurrentValue = false;
				}

			}
			return base.SaveChanges();
		}

		//public System.Data.Entity.DbSet<SistemaUniben.Application.ViewModels.ClienteViewModel> ClienteViewModels { get; set; }
	}
}