﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Infra.Data.EntityConfig
{
	public class InstituicaoConfiguration : EntityTypeConfiguration<Instituicao>
	{
		public InstituicaoConfiguration()
		{
			ToTable("Instituicoes");
			HasKey(p => p.InstituicaoId);

			Property(p => p.CNPJ).HasMaxLength(15);
			Property(p => p.Nome).HasMaxLength(200);
			Property(p => p.NomeFantasia).HasMaxLength(200);
			Property(p => p.Situacao).HasMaxLength(200);
			Property(p => p.Telefone).HasMaxLength(11);
			Property(p => p.Email).HasMaxLength(200);
			Property(p => p.DataAbertura).IsRequired();
			Property(p => p.NaturezaJuridica).HasMaxLength(100);
			Property(p => p.Atividade).HasMaxLength(200);
			Property(p => p.Codigo).HasMaxLength(100);

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