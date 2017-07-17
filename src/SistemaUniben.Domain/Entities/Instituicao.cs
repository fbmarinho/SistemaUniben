using System;
using System.Collections.Generic;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Instituicao : PessoaJuridica
	{
		public Instituicao()
		{
			InstituicaoId = Guid.NewGuid();
		}

		public Guid InstituicaoId { get; set; }

	}
}