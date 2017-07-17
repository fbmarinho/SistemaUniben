using System;
using System.CodeDom;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using Microsoft.Practices.ServiceLocation;
using SistemaUniben.Domain.Entities;
using SistemaUniben.Domain.Interfaces.Services;
using SistemaUniben.Domain.Services;
using SistemaUniben.Infra.Data.Context;
using SistemaUniben.Infra.Data.Interfaces;

namespace SistemaUniben.Infra.Data.Factories
{
	public class EmpresaFactory
	{

		private readonly SistemaUnibenContext _context;

		public EmpresaFactory(SistemaUnibenContext context)
		{
			_context = context;
		}

		public void Run()
		{
			var obj = new Empresa
			{
				Nome = "Empresa 1",
				NomeFantasia = "Empresa de Teste 1",
				CNPJ = "011789456000189",
				DataAbertura = DateTime.Now
			};
			_context.Empresas.AddOrUpdate(o => o.CNPJ, obj);
		}
	}
}