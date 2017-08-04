using AutoMapper;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Application.AutoMapper
{
	public class DomainToViewModelMappingProfile : Profile
	{
		public DomainToViewModelMappingProfile()
		{
			CreateMap<Cliente, ClienteViewModel>();
			CreateMap<Empresa, EmpresaViewModel>();
			CreateMap<Operadora, OperadoraViewModel>();
			CreateMap<Instituicao, InstituicaoViewModel>();
			CreateMap<Produto, ProdutoViewModel>();
		}


	}
}