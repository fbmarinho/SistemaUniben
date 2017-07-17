using System;
using System.Collections.Generic;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Empresa : PessoaJuridica
	{
		public Empresa()
		{
			EmpresaId = Guid.NewGuid();
		}

		public Guid EmpresaId { get; set; }
		
	}
}