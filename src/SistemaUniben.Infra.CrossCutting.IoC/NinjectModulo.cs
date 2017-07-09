using Ninject.Modules;
using SistemaUniben.Application;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;
using SistemaUniben.Domain.Services;
using SistemaUniben.Infra.Data.Context;
using SistemaUniben.Infra.Data.Interfaces;
using SistemaUniben.Infra.Data.Repositories;
using SistemaUniben.Infra.Data.UoW;

namespace SistemaUniben.Infra.CrossCutting.IoC
{
	public class NinjectModulo : NinjectModule
	{
		public override void Load()
		{
			// Data Config
			Bind<IContextManager>().To<ContextManager>();
			Bind<IUnitofWork>().To<UnitOfWork>();

			// App
			Bind<IClienteAppService>().To<ClienteAppService>();
			Bind<IEmpresaAppService>().To<EmpresaAppService>();
			Bind<IOperadoraAppService>().To<OperadoraAppService>();
			Bind<IInstituicaoAppService>().To<InstituicaoAppService>();

			// Domain Service
			Bind<IClienteService>().To<ClienteService>();
			Bind<IEmpresaService>().To<EmpresaService>();
			Bind<IOperadoraService>().To<OperadoraService>();
			Bind<IInstituicaoService>().To<InstituicaoService>();

			// Data
			Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
			Bind<IClienteRepository>().To<ClienteRepository>();
			Bind<IEmpresaRepository>().To<EmpresaRepository>();
			Bind<IOperadoraRepository>().To<OperadoraRepository>();
			Bind<IInstituicaoRepository>().To<InstituicaoRepository>();
		}
	}
}