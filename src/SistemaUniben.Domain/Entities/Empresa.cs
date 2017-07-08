using System;
using System.Collections.Generic;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Empresa : PessoaJuridica
	{
		public Empresa()
		{
			EmpresaId = new Guid();
		}

		public Guid EmpresaId { get; set; }
		
	}
}