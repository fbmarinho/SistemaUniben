using System.Collections.Generic;

namespace SistemaUniben.Domain.Entities.Listas
{
	public class Listas
	{
		public List<string> TipoContratacao = new List<string>()
		{
			"Adesão",
			"Empresarial"
		};

		public List<string> AbrangenciaGeografica = new List<string>()
		{
			"Nacional",
			"Estadual",
			"Municipal"
		};

		public List<string> Acomodacao = new List<string>()
		{
			"Ambulatorial",
			"Apartamento",
			"Nenhum"
		};

		public List<string> GrauParentescoPermitido = new List<string>()
		{
			"Pai/Mãe",
			"Cônjuge",
			"Genro/Sogra",
			"Avô/Avó",
			"Filhos",
			"Genro/Nora"
		};

	}
}