using System;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Cliente : PessoaFisica
	{
		public Cliente()
		{
			ClienteId = Guid.NewGuid();
		}
		public Guid ClienteId { get; set; }
	}
}