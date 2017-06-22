﻿using AutoMapper;
using SistemaUniben.Application.ViewModels;
using SistemaUniben.Domain.Entities;

namespace SistemaUniben.Application.AutoMapper
{
	public class ViewModelToDomainMappingProfile : Profile
	{
		public ViewModelToDomainMappingProfile()
		{
			CreateMap<ClienteViewModel, Cliente>();
			CreateMap<OperadoraViewModel, Operadora>();
			CreateMap<InstituicaoViewModel, Instituicao>();
		}
	}
}