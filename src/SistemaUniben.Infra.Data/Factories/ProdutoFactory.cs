using System;
using System.Data.Entity.Migrations;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Infra.Data.Context;

namespace SistemaUniben.Infra.Data.Factories
{
	public class ProdutoFactory
	{
		private readonly SistemaUnibenContext _context;

		public ProdutoFactory(SistemaUnibenContext context)
		{
			_context = context;
		}

		public void Run()
		{
			Console.Write("Criando lista de produtos...");
			var obj = new Produto
			{
				Nome = "Plano 1",
				NumeroRegistro = "001",
				Sigla = "PDT1",
				DataRegistro = DateTime.Now,
				Valor = 100,
				PorcentagemPrimeiraMensalidade = 1,
				TipoContratacao = "Adesão",
				AbrangenciaGeografica = "Nacional",
				Acomodacao = "Quarto",
				Coparticipacao = true,
				Observacao = "Observações do plano 1",
				IsValid = true,
				Ativo = true,
				DataCadastro = DateTime.Now,
				GrauParentescoPermitido = "Mãe, Pai, Conjuge, Sogro, Sogra"
			};
			_context.Produtos.AddOrUpdate(o => o.ProdutoId, obj);

			obj = new Produto
			{
				Nome = "Plano 2",
				NumeroRegistro = "002",
				Sigla = "PDT2",
				DataRegistro = DateTime.Now,
				Valor = 200,
				PorcentagemPrimeiraMensalidade = 1,
				TipoContratacao = "Empresarial",
				AbrangenciaGeografica = "Estadual",
				Acomodacao = "Ambulatorio",
				Coparticipacao = true,
				Observacao = "Observações do plano 2",
				IsValid = true,
				Ativo = true,
				DataCadastro = DateTime.Now,
				GrauParentescoPermitido = "Mãe, Pai, Conjuge, Sogro, Sogra"
			};
			_context.Produtos.AddOrUpdate(o => o.ProdutoId, obj);

			obj = new Produto
			{
				Nome = "Plano 3",
				NumeroRegistro = "003",
				Sigla = "PDT3",
				DataRegistro = DateTime.Now,
				Valor = 300,
				PorcentagemPrimeiraMensalidade = 1,
				TipoContratacao = "Adesão",
				AbrangenciaGeografica = "Regional",
				Acomodacao = "Compartilhado",
				Coparticipacao = true,
				Observacao = "Observações do plano 3",
				IsValid = true,
				Ativo = true,
				DataCadastro = DateTime.Now,
				GrauParentescoPermitido = "Mãe, Pai, Conjuge, Sogro, Sogra"
			};
			_context.Produtos.AddOrUpdate(o => o.ProdutoId, obj);
		}
	}
}