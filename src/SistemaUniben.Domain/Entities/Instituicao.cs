using System;
using System.Collections.Generic;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Instituicao : PessoaJuridica
	{
		public Instituicao()
		{
			InstituicaoId = new Guid();
		}

		public Guid InstituicaoId { get; set; }

	}
}