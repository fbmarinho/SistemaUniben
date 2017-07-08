using System;
using System.Collections.Generic;

namespace SistemaUniben.Domain.Entities.Abstract
{
	public abstract class PessoaFisica
	{
		public string Nome { get; set; }
		public string Sobrenome { get; set; }
		public string CPF { get; set; }
		public string RG { get; set; }
		public DateTime DataNascinmento { get; set; }
		
		//Endereco
		public int EnderecoPadrao { get; set; }
		public virtual ICollection<Endereco> Enderecos { get; set; }
	}
}