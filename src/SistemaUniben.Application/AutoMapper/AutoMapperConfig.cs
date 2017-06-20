using AutoMapper;

namespace SistemaUniben.Application.AutoMapper
{
	public class AutoMapperConfig
	{
		public static void RegisterMappings()
		{
			Mapper.Initialize(x =>
			{
				x.AddProfile<ViewModelToDomainMappingProfile>();
				x.AddProfile<DomainToViewModelMappingProfile>();
			});
		}
	}
}