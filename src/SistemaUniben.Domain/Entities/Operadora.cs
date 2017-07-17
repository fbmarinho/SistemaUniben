using System;
using System.Collections.Generic;
using System.Text;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Operadora : PessoaJuridica
	{
		public Operadora()
		{
			OperadoraId = Guid.NewGuid();
		}
		public Guid OperadoraId { get; set; }
	}
}