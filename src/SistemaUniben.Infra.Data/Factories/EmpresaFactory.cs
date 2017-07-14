using System.CodeDom;
using System.Data.Entity;
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
		private readonly IEmpresaService _empresaService;


		public EmpresaFactory(IEmpresaService empresaService)
		{
			_empresaService = empresaService;
		}

		public void run()
		{
			var obj = new Empresa()
			{
				Nome = "Empresa 1",
				NomeFantasia = "Empresa de Teste 1",
				CNPJ = "011789456000189"
			};
			_empresaService.Adicionar(obj);
		}
	}
}