using Ninject.Modules;
using SistemaUniben.Application;
using SistemaUniben.Application.Interfaces;
using SistemaUniben.Domain.Interfaces.Repositories;
using SistemaUniben.Domain.Interfaces.Services;
using SistemaUniben.Domain.Services;
using SistemaUniben.Infra.Data.Repositories;

namespace SistemaUniben.Infra.CrossCutting.IoC
{
	public class NinjectModulo : NinjectModule
	{
		public override void Load()
		{
			// App
			Bind<IClienteAppService>().To<ClienteAppService>();
			Bind<IOperadoraAppService>().To<OperadoraAppService>();

			// Domain Service
			Bind<IClienteService>().To<ClienteService>();
			Bind<IOperadoraService>().To<OperadoraService>();

			// Data
			Bind(typeof(IBaseRepository<>)).To(typeof(BaseRepository<>));
			Bind<IClienteRepository>().To<ClienteRepository>();
			Bind<IOperadoraRepository>().To<OperadoraRepository>();
		}
	}
}