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
		public DbSet<Endereco> Enderecos { get; set; }
		public DbSet<Operadora> Operadoras { get; set; }
		public DbSet<Instituicao> Instituicoes { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{

			// Configuração do framework
			modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
			modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
			modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

			// Configuração de cada tabela
			modelBuilder.Configurations.Add(new EnderecoConfiguration());
			modelBuilder.Configurations.Add(new ClienteConfiguration());
			modelBuilder.Configurations.Add(new OperadoraConfiguration());
			modelBuilder.Configurations.Add(new InstituicaoConfiguration());


			// Configuração das tabelas padrão
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
					entry.Property("DataCadastro").IsModified = false;
				}

			}
			return base.SaveChanges();
		}
	}
}