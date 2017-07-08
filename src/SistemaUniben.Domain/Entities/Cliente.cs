using System;
using SistemaUniben.Domain.Entities.Abstract;

namespace SistemaUniben.Domain.Entities
{
	public class Cliente : PessoaFisica
	{
		public Cliente()
		{
			ClienteId = new Guid();
		}
		public Guid ClienteId { get; set; }
	}
}